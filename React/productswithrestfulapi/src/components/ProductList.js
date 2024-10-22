import React from 'react'

const ProductList = ({products, onDelete, editProduct}) => {

  const onDeleting = (event) => {
    const productId = event.target.value;
    onDelete(productId);
  }
  const productEdit=(id)=>{
    editProduct(id);
  }
  return (
    <div>
      <table className='table table-striped w-75 m-auto'>
        <thead>
          <th>Id</th>
          <th>Name</th>
          <th>Price</th>
          <th>Stock</th>
          <th>Category</th>
          <th></th>
        </thead>
        <tbody>
          {
            products.map((product, index) => {
              return(
                <tr key="index">
                  <td>{product.id}</td>
                  <td>{product.name}</td>
                  <td>{product.price}</td>
                  <td>{product.stock}</td>
                  <td>{product.category}</td>
                  <td>
                    <button className='btn btn-danger me-3' onClick={() => productEdit(product.id)}>Edit</button>
                    <button className='btn btn-danger' value={product.id} onClick={onDeleting}>Delete</button>
                  </td>
                </tr>
              )
            })
          }
        </tbody>
      </table>

    </div>
  )
}

export default ProductList