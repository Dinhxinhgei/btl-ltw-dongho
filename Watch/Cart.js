function quantityControl() {
    const cartpageItems = document.querySelectorAll(".cart-item");
    
    cartpageItems.forEach((item) => {
        const quantityInput = item.querySelector(".qty_input");
        const quantityUp = item.querySelector(".qtt_up");
        const quantityDown = item.querySelector(".qtt_down");
        const productPrice = item.querySelector(".product-price");
        const cartpageTotal = item.querySelector(".total_cart");
        
        cartpageTotal.innerHTML = `${(parseFloat(productPrice.innerHTML.split(",").join("")) * quantityInput.value).toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,')}`;

        quantityUp.addEventListener("click", () => {
            const quantityNumber = parseInt(quantityInput.value);
            quantityInput.value = quantityNumber + 1;
            changePrice(cartpageTotal, quantityInput, productPrice);
        })
        quantityDown.addEventListener("click", () => {
            const quantityNumber = parseInt(quantityInput.value);
            quantityInput.value = quantityNumber == 1 ? 1 : quantityNumber - 1;
            changePrice(cartpageTotal, quantityInput, productPrice);
        })

        quantityInput.addEventListener("keyup", () => {
            changePrice(cartpageTotal, quantityInput, productPrice);
        })

        quantityInput.addEventListener("blur", () => {
            if (quantityInput.value == "") {
                quantityInput.value = 1;
                changePrice(cartpageTotal, quantityInput, productPrice)
            }
        })
    })

    function changePrice(cartpageTotal, quantityInput, productPrice) {
        if (isNaN(quantityInput.value) || (quantityInput.value <= 0 && quantityInput.value != ""))
            quantityInput.value = 1;
        const a = (quantityInput.value * parseFloat(productPrice.innerHTML.split(",").join("")));
        cartpageTotal.innerHTML = `${a.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,')}`;
        
        changeSumary();
    }

    function changeSumary() {
        const productCount = document.querySelector(".cart__products_total_count .cart__product_price_unit");
        const productPriceTotal = document.querySelector(".cart__order_total .cart__product_price_unit");
        var count = 0, priceTotal = 0;

        cartpageItems.forEach((item) => {
            const quantityInput = item.querySelector(".qty_input");
            const cartpageTotal = item.querySelector(".total_cart");

            count += parseInt(quantityInput.value);
            priceTotal += parseFloat(cartpageTotal.innerHTML.split(",").join(""));
        })

        productCount.innerHTML = `${count}`;
        productPriceTotal.innerHTML = `${(priceTotal).toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,')}đ`;
    }
    changeSumary();

    function strToFloat(str) {
        return parseFloat(str.split(",").join(""));
    }
}
quantityControl();