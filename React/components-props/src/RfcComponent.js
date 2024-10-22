import React from 'react'

const RfcComponent = ({title, description, image}) => {
  // console.log(props);
  // const title = props.title;
  // const description = props.description;
  // const {title, description} = props;
  return (
    <div>
        <h1>{title}</h1>
        <img src={image} alt="react"></img>
        <h2>{description}</h2>
      {/* <h1>{props.title}</h1>
      <h2>{props.description}</h2> */}
    </div>
    
  )
}

//rfc (react functional component)
// export default function rfcComponent() {
//   return (
//     <div>rfcComponent</div>
//   )
// }


//rfce (react functional component export)
// function rfcComponent() {
//   return (
//     <div>rfcComponent</div>
//   )
// }

export default RfcComponent