const html = window.igTemplating.html;
igRegisterScript("columnBodyTemplateScript", (ctx) => {
    return html`
        <a customers-scope @click=${() => window.dotNetHelper.invokeMethodAsync('clickHyperlink', ctx)} class="typography__body-2 hyperlink">
            ${ctx.cell.value}
        </a>
    `
}, false);
igRegisterScript("columnBodyTemplateScript1", (ctx) => {
    return html`
        <igc-chip customers-scope class="chip">
            <span customers-scope slot="prefix">
                <span customers-scope class="material-icons icon_2">
                    phone
                </span>
            </span>
            ${ctx.cell.value}
        </igc-chip>
    `
}, false);

window.setDotNetRef = (dotNetHelper) => {
    window.dotNetHelper = dotNetHelper;
}
