
document.addEventListener('DOMContentLoaded', function() {

    /* TOMSELECT */

    document.querySelectorAll('.searchable-select').forEach(function(select) {

        new TomSelect(select, {
            create: false,
            allowEmptyOption: true,
            maxOptions: null,
            placeholder: select.dataset.placeholder || 'Select option',

            onDropdownOpen: function() {
                this.setTextboxValue('');
                this.control_input.focus();
                this.control_input.setSelectionRange(0, 0);
            }
        });

    });

    /* GLOBAL VALIDATION SCROLL */

    const validationMessage = document.querySelector(
        'main .field-validation-error[data-valmsg-for]'
    );

    const fieldName = validationMessage?.getAttribute('data-valmsg-for');

    const invalidField =
        document.querySelector('main .input-validation-error, main .is-invalid, main [aria-invalid="true"]') ||
        (fieldName ? document.getElementsByName(fieldName)[0] : null);

    const target =
        invalidField?.tomselect?.control ||
        invalidField ||
        document.querySelector('main .validation-summary-errors');

    if (!target) {
        return;
    }

    function scrollToError() {

        target.scrollIntoView({
            behavior: 'smooth',
            block: 'center'
        });

        if (invalidField && !invalidField.tomselect) {
            invalidField.focus({ preventScroll: true });
        }
    }

    const collapsedPanel = target.closest('.collapse:not(.show)');

    if (collapsedPanel && typeof bootstrap !== 'undefined') {

        collapsedPanel.addEventListener(
            'shown.bs.collapse',
            scrollToError,
            { once: true }
        );

        bootstrap.Collapse.getOrCreateInstance(
            collapsedPanel,
            { toggle: false }
        ).show();

    } else {
        scrollToError();
    }

});
