document.addEventListener("DOMContentLoaded", () => {
    iniciarResumenPedido();
    iniciarFiltrosMenu();
});

const formatear = (valor) => "$" + Math.round(valor).toLocaleString("es-CO");

/* ---------- Resumen en vivo (Pedidos/Crear) ---------- */
function iniciarResumenPedido() {
    const producto = document.getElementById("producto");
    const tamano = document.getElementById("tamano");
    const cantidad = document.getElementById("cantidad");
    const total = document.getElementById("totalVivo");
    if (!producto || !tamano || !cantidad || !total) return;

    const factores = { "Pequeño": 1, "Mediano": 1.25, "Grande": 1.5 };

    function calcular() {
        const opt = producto.options[producto.selectedIndex];
        const precio = parseFloat(opt?.dataset.precio || 0);
        const cant = parseInt(cantidad.value) || 0;

        const subtotal = precio * (factores[tamano.value] || 1) * cant;
        const descuento = cant >= 5 ? subtotal * 0.10 : 0;

        document.getElementById("resProducto").textContent = opt?.dataset.nombre || "-";
        document.getElementById("resTamano").textContent = tamano.value;
        document.getElementById("resCantidad").textContent = cant;
        document.getElementById("resSubtotal").textContent = formatear(subtotal);
        document.getElementById("resDescuento").textContent = formatear(descuento);
        total.textContent = formatear(subtotal - descuento);
    }

    [producto, tamano, cantidad].forEach(el => el.addEventListener("input", calcular));
    calcular();
}

/* ---------- Filtros y buscador (Menu/Index) ---------- */
function iniciarFiltrosMenu() {
    const botones = document.querySelectorAll(".filtro-btn");
    const items = document.querySelectorAll(".item-menu");
    const buscador = document.getElementById("buscar");
    const sinResultados = document.getElementById("sinResultados");
    if (!botones.length || !items.length) return;

    let categoriaActual = "todos";

    function aplicar() {
        const texto = (buscador?.value || "").toLowerCase().trim();
        let visibles = 0;

        items.forEach(item => {
            const coincideCategoria = categoriaActual === "todos" || item.dataset.categoria === categoriaActual;
            const coincideTexto = item.dataset.nombre.includes(texto);
            const mostrar = coincideCategoria && coincideTexto;
            item.classList.toggle("d-none", !mostrar);
            if (mostrar) visibles++;
        });

        sinResultados?.classList.toggle("d-none", visibles > 0);
    }

    botones.forEach(boton => {
        boton.addEventListener("click", () => {
            botones.forEach(b => b.classList.remove("active"));
            boton.classList.add("active");
            categoriaActual = boton.dataset.categoria;
            aplicar();
        });
    });

    buscador?.addEventListener("input", aplicar);
}