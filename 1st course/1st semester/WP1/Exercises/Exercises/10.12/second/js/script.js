let grandTotal = 0;

function AddNewProduct() {
  const productName = document.getElementById("product-name").value;
  const productPrice = document.getElementById("product-price").value;
  const productQuantity = document.getElementById("product-quantity").value;

  if (!productName || !productPrice || !productQuantity) {
    alert("Моля, попълнете всички полета.");
    return;
  }

  const total = parseFloat(productPrice) * parseInt(productQuantity);

  const tbody = document.getElementById("products").querySelector("tbody");

  const row = document.createElement("tr");
  const nameCell = document.createElement("td");
  const priceCell = document.createElement("td");
  const quantityCell = document.createElement("td");
  const totalCell = document.createElement("td");

  nameCell.textContent = productName;
  priceCell.textContent = productPrice;
  quantityCell.textContent = productQuantity;
  totalCell.textContent = total;

  row.appendChild(nameCell);
  row.appendChild(priceCell);
  row.appendChild(quantityCell);
  row.appendChild(totalCell);
  tbody.appendChild(row);

  grandTotal += total;
  document.getElementById("total").textContent = grandTotal;

  document.getElementById("product-name").value = "";
  document.getElementById("product-price").value = "";
  document.getElementById("product-quantity").value = "";
}
