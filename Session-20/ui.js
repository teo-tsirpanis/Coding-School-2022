// 1.
const reverseInput = document.getElementById("reverse-input");
const reverseOutput = document.getElementById("reverse-output");

reverseInput.addEventListener("input", () => {
    reverseOutput.innerText = reverseString(reverseInput.value);
});

// 3.
const customerDetails = document.getElementById("customer-details");
const customerName = document.getElementById("customer-name");
const customerSurname = document.getElementById("customer-surname");
const customerAge = document.getElementById("customer-age");
const customerGender = document.getElementById("customer-gender");

const btnAdd = document.getElementById("btn-add");
const btnUpdate = document.getElementById("btn-update");
const btnDelete = document.getElementById("btn-delete");

let activeRow = null;

function serializeCustomer(customer, dataset) {
    dataset.name = customer.name;
    dataset.surname = customer.surname;
    dataset.age = customer.age;
    dataset.gender = customer.gender;
}

function deserializeCustomer(dataset) {
    return {
        "name" : dataset.name,
        "surname" : dataset.surname,
        "age" : dataset.age,
        "gender" : dataset.gender,
    };
}

function setActiveCustomer(_) {
    if (this === activeRow)
        return;
    activeRow?.classList.remove("selected");
    activeRow = this;
    activeRow.classList.add("selected");
    btnDelete.disabled = false;

    customerName.value = activeRow.children[0].innerText;
    customerSurname.value = activeRow.children[1].innerText;
    customerAge.value = activeRow.children[2].innerText;
    customerGender.value = activeRow.children[3].innerText;
}

btnAdd.addEventListener("click", () => {
    const newRow = document.createElement("tr");
    newRow.classList.add("selected");

    for (const elt of [customerName, customerSurname, customerAge, customerGender])
        newRow.appendChild(createTd(elt.value));

    newRow.addEventListener("click", setActiveCustomer);

    customerDetails.appendChild(newRow);
    activeRow?.classList.remove("selected");
    activeRow = newRow;
    btnDelete.disabled = false;

    function createTd(text) {
        const td = document.createElement("td");
        td.appendChild(document.createTextNode(text));
        return td;
    }
});

btnUpdate.addEventListener("click", () => {
    if (activeRow === null)
        return;

    activeRow.children[0].innerText = customerName.value;
    activeRow.children[1].innerText = customerSurname.value;
    activeRow.children[2].innerText = customerAge.value;
    activeRow.children[3].innerText = customerGender.value;
});

btnDelete.addEventListener("click", () => {
    if (activeRow === null)
        return;

    customerDetails.removeChild(activeRow);
    activeRow = null;
    btnDelete.disabled = true;

    customerName.value = "";
    customerSurname.value = "";
    customerAge.value = "";
    customerGender.value = "";
});
