document.addEventListener("DOMContentLoaded", () => {
    const producto = document.getElementById("producto");
    const tamano = document.getElementById("tamano");
    const cantidad = document.getElementById("cantidad");
    const total = document.getElementById("totalVivo");
    if (!producto || !total) return;

    const factores = { "Pequeño": 1, "Mediano": 1.25, "Grande": 1.5 };

    function calcular() {
        const opt = producto.options[producto.selectedIndex];
        const precio = parseFloat(opt?.dataset.precio || 0);
        const cant = parseInt(cantidad.value) || 0;
        let sub = precio * (factores[tamano.value] || 1) * cant;
        if (cant >= 5) sub *= 0.9;
        total.textContent = sub.toLocaleString("es-CO", { style: "currency", currency: "COP", maximumFractionDigits: 0 });
    }

    [producto, tamano, cantidad].forEach(el => el.addEventListener("input", calcular));
    calcular();
});