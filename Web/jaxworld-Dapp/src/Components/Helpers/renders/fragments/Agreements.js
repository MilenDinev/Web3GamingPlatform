import { useState } from 'react';

export function Agreements() {
  const [privacyPolicy, setPrivacyPolicy] = useState(false);

  const handlePrivacyPolicy = (event) => {
    setPrivacyPolicy(event.target.checked);
  };

  const [termsOfUse, setTermsOfUse] = useState(false);
  const handleTermsOfUse = (event) => {
    setTermsOfUse(event.target.checked);
  };

  const inputs = (
    <>
      <hr className="my-2 fonts-style eligibility"></hr>
      <div className="fonts">
        <div className="form-check text-opacity-75">
          <input
            className="form-check-input fonts-style eligibility"
            type="checkbox"
            onChange={handlePrivacyPolicy}
          />
          <label className="form-check-label fonts-style eligibility agreements">
            Agree with <a className="text-decoration-none" href="privacy-policy">Privacy Policy</a>
          </label>
        </div>

        <div className="form-check text-opacity-75">
          <input
            className="form-check-input fonts-style eligibility"
            type="checkbox"
            onChange={handleTermsOfUse}
          />
          <label className="form-check-label fonts-style eligibility agreements">
            Agree with <a className="text-decoration-none" href="terms-of-use">Terms Of Use</a>
          </label>
        </div>
      </div>
    </>
  );

  return {
    termsOfUse,
    privacyPolicy,
    inputs,
  };
}