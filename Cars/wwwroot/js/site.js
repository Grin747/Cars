const brandModal = document.getElementById('brandModal')
if (brandModal) {
    brandModal.addEventListener('show.bs.modal', event => {
        const button = event.relatedTarget
        const modalTitle = brandModal.querySelector('.modal-title')
        const id = button.getAttribute('data-bs-brand-id')

        if (id == null) {

            const form = brandModal.querySelector('#brandUpdate')
            form.action = "/CarBrand/Add"
            modalTitle.textContent = "Create brand"
        } else {

            const title = button.getAttribute('data-bs-brand-title')
            const active = button.getAttribute('data-bs-brand-active') === "True"
            const brandTitle = brandModal.querySelector('.modal-body #brand-title')
            const brandSwitch = brandModal.querySelector('.modal-body #brand-active')
            const brandId = brandModal.querySelector('.modal-body #brand-id')

            modalTitle.textContent = `Update ${title}`
            brandTitle.value = title
            brandId.value = id

            brandSwitch.checked = active
        }
    })
}


const modelModal = document.getElementById('modelModal')
if (modelModal) {
    modelModal.addEventListener('show.bs.modal', event => {
        const button = event.relatedTarget
        const modalTitle = modelModal.querySelector('.modal-title')
        const id = button.getAttribute('data-bs-model-id')

        if (id == null) {

            const form = modelModal.querySelector('#modelUpdate')
            form.action = "/CarModel/Add"
            modalTitle.textContent = "Create model"

            modelModal.querySelector('.modal-body #model-active').checked = false
            modelModal.querySelector('.modal-body #model-id').value = 0
            modelModal.querySelector('.modal-body #model-brand').value = 0
            modelModal.querySelector('.modal-body #model-title').value = ""
            
        } else {

            const title = button.getAttribute('data-bs-model-title')
            const active = button.getAttribute('data-bs-model-active') === "True"
            const brand = button.getAttribute('data-bs-model-brand')

            modelModal.querySelector('.modal-body #model-active').checked = active
            modelModal.querySelector('.modal-body #model-id').value = id
            modelModal.querySelector('.modal-body #model-brand').value = brand
            modelModal.querySelector('.modal-body #model-title').value = title
            modalTitle.textContent = `Update ${title}`
        }
    })
}