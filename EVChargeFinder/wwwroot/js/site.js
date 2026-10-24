document.addEventListener('DOMContentLoaded', function () {

    document.querySelectorAll('.searchable-select').forEach(function (select) {

        new TomSelect(select, {
            create: false,
            allowEmptyOption: true,
            maxOptions: null,
            placeholder: select.dataset.placeholder || 'Select option',

            onDropdownOpen: function () {

                this.setTextboxValue('');

                this.control_input.focus();

                this.control_input.setSelectionRange(0, 0);
            }
        });

    });

});