import React from "react";

const Card = ({ education }) => {
  return (
    <div className="col-md-4">
      <div className="card my-2 bg-body-secondary">
        <div className="card-title text-dark fs-3">{education.title}</div>
        <div className="card-image">
          <img
            src={education.image}
            alt={education.title}
            width="300px"
            height="150px"
          />
        </div>
      </div>
    </div>
  );
};

export default Card;
