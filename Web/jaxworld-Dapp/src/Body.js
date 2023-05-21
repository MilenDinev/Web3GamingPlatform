import React from "react";
import HeroContent from "./Components/Helpers/HeroContent";
import Mint from "./Components/Mint";
import { ContractData } from "./Components/GetContractData";

function Body() {
  return (
    <>
      <HeroContent />
      <Form />
    </>
  );
}

function Form() {
  return (
    <div className="col-md-10 mx-auto col-lg-5">
      <form className="p-4 p-md-5 border border-secondary border-opacity-50 rounded-5 bg-transparent">
        <ContractData />
        <Mint />

        <hr className="my-4"></hr>
        <div className="form-control border-0 bg-secondary bg-gradient rounded-4 p-2 text-muted text-opacity-75 bg-opacity-10 form-floating mb-3">
          <div className="form-check">
            <input
              className="form-check-input"
              type="checkbox"
              value=""
              id="flexCheckDefault"
              required
            ></input>
            <label className="form-check-label" htmlFor="flexCheckDefault">
              Agree with Privacy Policy
            </label>
          </div>
        

        <div className="form-check">
          <input
            className="form-check-input"
            type="checkbox"
            value=""
            id="flexCheckChecked"
            required
          ></input>
          <label className="form-check-label" htmlFor="flexCheckChecked">
            Agree with Terms Of Use
          </label>
        </div>

        
        <small className="text-white">
          It is necessary to agree to the Privacy Policy and Terms of Use.
        </small>
        </div>
      </form>    
    </div>
  );
}

export default Body;
