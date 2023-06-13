import { Link } from 'react-router-dom';

export function Footer() {
  return (

    <div className="container">
    <footer className=" d-flex flex-wrap justify-content-between align-items-center py-1 border-top  border-secondary footer-nav-main text">
      <ul className="nav col-md-3 justify-content-start">
        <li className="ms-2" data-toggle="tooltip" title="Discord"><Link className="text-muted" target="_blank" rel="noreferrer" to="https://discord.com/invite/dPNE6fK4S4"><i className="bi bi-discord hover-effect" style={{ fontSize: 30 }}></i></Link></li>
        <li className="ms-2" data-toggle="tooltip" title="Twitter"><Link className="text-muted" target="_blank" rel="noreferrer" to="https://twitter.com/jaxworld_"><i className="bi bi-twitter hover-effect" style={{ fontSize: 30 }}></i></Link></li>
        <li className="ms-2" data-toggle="tooltip" title="Medium"><Link className="text-muted" target="_blank" rel="noreferrer" to="https://medium.com/@jaxminersworld"><i className="bi bi-medium hover-effect" style={{ fontSize: 30 }}></i></Link></li>
      </ul>
      <Link to="/" data-toggle="tooltip" title="Home" rel="noreferrer" className="menu-button text-muted col-md-5 d-flex justify-content-center text-decoration-none">
        <label className="col-md-5 mb-0 hover-effect">&copy; 2023 Jax World</label>
      </Link>
  
      <ul className=" nav col-sm-4 col-md-3 col-lg-3 col-xl-4 col-xxl-4 justify-content-end">
        <li className="nav-item" data-toggle="tooltip" title="Contact Us"><Link to="contact" rel="noreferrer" className="menu-button nav-link px-2 text-muted"><label className="hover-effect">Contact Us</label></Link></li>
        <li className="nav-item" data-toggle="tooltip" title="FAQ"><Link to="https://docs.jaxworld.xyz/faq" target="_blank" rel="noreferrer" className="menu-button nav-link px-2 text-muted "><label className="hover-effect">FAQ</label></Link></li>
        <li className="nav-item" data-toggle="tooltip" title="Terms of use"><Link to="terms-of-use" rel="noreferrer" className="menu-button nav-link px-2 text-muted"><label className="hover-effect">Terms of Use</label></Link></li>
        <li className="nav-item" data-toggle="tooltip" title="Privacy Policy"><Link to="privacy-policy" rel="noreferrer" className="menu-button nav-link px-2 text-muted"><label className="hover-effect">Privacy policy</label></Link></li>
      </ul>
    </footer>
    </div>
  );
}
