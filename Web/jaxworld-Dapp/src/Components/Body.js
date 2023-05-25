import React from "react";
import { Claim } from "./Helpers/renders/units/Claim";
import { ContractData } from "./Helpers/renders/units/ContractData";
import HeroContent from "./Helpers/renders/units/HeroContent";

function Body() {


  return (
      <>
      <BodyContent/>
      </>   
  );
}


function BodyContent() {
  return (
    <div className="container col-xl-10 col-xxl-8 px-4 py-5">
      <div className="row align-items-center g-lg-5 py-5">
          <HeroContent/>
        <div className="col-md-10 mx-auto col-lg-5">
          <form className="p-4 p-md-5 border border-secondary border-opacity-50 rounded-5 bg-transparent">
            <ContractData />
            <Claim />
            <hr className="my-4"></hr>
            <div className="form-control border-0 bg-secondary bg-gradient rounded-4 p-2 text-muted bg-opacity-10 form-floating mb-3">
              <div className="form-check text-opacity-75">
                <input
                  className="form-check-input"
                  type="checkbox"
                  value=""
                  id="flexCheckDefault"
                  required
                >                  
                </input>
                <label className="form-check-label" htmlFor="flexCheckDefault">
                  Agree with Privacy Policy
                </label>
              </div>
            
    
            <div className="form-check text-opacity-75">
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

      </div>


    </div>
  );
}

export default Body;
