import React, { useState } from "react";
import IPosition from "../../shared/interfaces/IPosition";
import "./Square.css";

export interface ISquareProps {
  onClick: (position: IPosition) => void;
  value?: any;
  position: IPosition;
  enabled: boolean;
}

export default function Square(props: ISquareProps) {
  const [style, setStyle] = useState("square");

  let btnId = `${props.position.xPosition}_${props.position.yPosition}`;

  const btnClick = () => {
    props.onClick(props.position);
    setStyle("square-update");
  };

  return (
    <button
      id={btnId}
      className={style}
      disabled={!props.enabled}
      onClick={btnClick}
    >
      {props.value}
    </button>
  );
}
