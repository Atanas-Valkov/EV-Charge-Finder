(() => {
    const canvas = document.getElementById("sessions-energy-chart");
    const dataElement = document.getElementById("sessions-energy-data");
    const periodSelect = document.getElementById("periodFilter");
    const emptyMessage = document.getElementById("sessions-chart-empty");

    if (!canvas || !dataElement || !periodSelect) {
        return;
    }

    const dailyEnergy = JSON.parse(dataElement.textContent);

    const now = new Date();

    const today = new Date(Date.UTC(
        now.getUTCFullYear(),
        now.getUTCMonth(),
        now.getUTCDate()
    ));

    const numberFormatter = new Intl.NumberFormat("en-GB", {
        maximumFractionDigits: 2
    });

    const dayFormatter = new Intl.DateTimeFormat("en-GB", {
        day: "2-digit",
        month: "short",
        timeZone: "UTC"
    });

    const monthFormatter = new Intl.DateTimeFormat("en-GB", {
        month: "short",
        year: "numeric",
        timeZone: "UTC"
    });

    function getPeriodData(period) {
        const monthly = period === "year";
        const count = monthly ? 12 : period === "week" ? 7 : 30;

        const buckets = new Map();

        for (let index = 0; index < count; index++) {
            const date = monthly
                ? new Date(Date.UTC(
                    today.getUTCFullYear(),
                    today.getUTCMonth() - count + 1 + index,
                    1
                ))
                : new Date(Date.UTC(
                    today.getUTCFullYear(),
                    today.getUTCMonth(),
                    today.getUTCDate() - count + 1 + index
                ));

            const key = date.toISOString().slice(0, monthly ? 7 : 10);

            buckets.set(key, {
                label: monthly
                    ? monthFormatter.format(date)
                    : dayFormatter.format(date),
                energy: 0
            });
        }

        const todayKey = today.toISOString().slice(0, 10);
        let hasData = false;

        for (const day of dailyEnergy) {
            if (day.date > todayKey) {
                continue;
            }

            const key = monthly ? day.date.slice(0, 7) : day.date;
            const bucket = buckets.get(key);

            if (bucket) {
                bucket.energy += Number(day.energyKWh);
                hasData = true;
            }
        }

        return {
            labels: Array.from(buckets.values(), bucket => bucket.label),
            values: Array.from(buckets.values(), bucket => bucket.energy),
            hasData
        };
    }

    const chart = new Chart(canvas, {
        type: "line",
        data: {
            labels: [],
            datasets: [{
                label: "Energy",
                data: [],
                borderColor: "#2999cf",
                borderWidth: 2,
                fill: true,
                tension: 0,
                pointRadius: 0,
                pointHoverRadius: 5,
                pointHoverBackgroundColor: "#2999cf",
                pointHoverBorderColor: "#ffffff",
                pointHoverBorderWidth: 2,
                backgroundColor(context) {
                    const { ctx, chartArea } = context.chart;

                    if (!chartArea) {
                        return "rgba(41, 153, 207, 0.12)";
                    }

                    const gradient = ctx.createLinearGradient(
                        0,
                        chartArea.top,
                        0,
                        chartArea.bottom
                    );

                    gradient.addColorStop(0, "rgba(41, 153, 207, 0.25)");
                    gradient.addColorStop(1, "rgba(41, 153, 207, 0.01)");

                    return gradient;
                }
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            interaction: {
                mode: "index",
                intersect: false
            },
            plugins: {
                legend: {
                    display: false
                },
                tooltip: {
                    backgroundColor: "#172033",
                    titleColor: "#ffffff",
                    bodyColor: "#dcecf5",
                    padding: 12,
                    displayColors: false,
                    callbacks: {
                        label(context) {
                            return `Energy: ${numberFormatter.format(context.parsed.y)} kWh`;
                        }
                    }
                }
            },
            scales: {
                x: {
                    grid: {
                        display: false
                    },
                    border: {
                        display: false
                    },
                    ticks: {
                        color: "#697386",
                        maxRotation: 0,
                        autoSkip: true,
                        maxTicksLimit: 12
                    }
                },
                y: {
                    beginAtZero: true,
                    border: {
                        display: false,
                        dash: [2, 5]
                    },
                    grid: {
                        color: "rgba(60, 50, 35, 0.08)"
                    },
                    ticks: {
                        color: "#697386",
                        maxTicksLimit: 5,
                        callback(value) {
                            return `${numberFormatter.format(value)} kWh`;
                        }
                    }
                }
            }
        }
    });

    function updateChart() {
        const period = periodSelect.value;
        const result = getPeriodData(period);

        chart.data.labels = result.labels;
        chart.data.datasets[0].data = result.values;
        chart.update();

        const heading = canvas.closest(".sessions-chart")?.querySelector("h3");

        if (heading) {
            heading.textContent = period === "year"
                ? "Monthly Energy · kWh"
                : "Daily Energy · kWh";
        }

        if (emptyMessage) {
            emptyMessage.hidden = result.hasData;
        }
    }

    periodSelect.addEventListener("change", updateChart);

    updateChart();
})();


document.querySelectorAll(".sessions-period-menu .dropdown-item")
    .forEach(item => {

        item.addEventListener("click", function () {

            const value = this.dataset.period;
            const text = this.textContent.trim();

            const periodFilter = document.getElementById("periodFilter");

            periodFilter.value = value;

            document.getElementById("periodFilterText").textContent = text;

            document.querySelectorAll(".sessions-period-menu .dropdown-item")
                .forEach(option => option.classList.remove("active"));

            this.classList.add("active");

            periodFilter.dispatchEvent(
                new Event("change", { bubbles: true })
            );
        });
    });