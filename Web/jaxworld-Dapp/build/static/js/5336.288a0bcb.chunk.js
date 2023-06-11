"use strict";(self.webpackChunkjaxworld_dapp=self.webpackChunkjaxworld_dapp||[]).push([[5336],{15336:function(e,t,n){n.r(t),n.d(t,{default:function(){return O}});var s=n(29439),r=n(74795),a=n(13248),i=n(47313),l=n(46417);function c(){return(0,l.jsxs)("label",{className:"mx-auto mb-sm-3 hero fonts col-sm-3 col-md-4 col-lg-5, col-xl-6 text-center text-lg-start bg-gradient p-1 rounded-5",children:[(0,l.jsx)("p",{className:"display-6 fw-bolder text-center mb-1 fonts-hero-fonts",children:"Jax World's Genesis NFT Collection"}),(0,l.jsx)("p",{className:"display-6 fw-bolder text-center mb-1 fonts-hero-fonts minions",children:"G Minions"}),(0,l.jsx)("p",{className:"fonts-style display-2 mb-0 text-center",children:"available soon"}),(0,l.jsx)("p",{className:"text-center fonts-hero-fonts",children:"exclusively for our community members."})]})}var o=n(31387);function d(){return{submit:function(){return o.Am.info("Transaction submitted!",{position:"bottom-center",autoClose:1e3,hideProgressBar:!1,closeOnClick:!0,pauseOnHover:!0,draggable:!0,progress:void 0,theme:"light"})},success:function(e){return o.Am.success("Successfully claimed!",{position:"bottom-center",autoClose:3e3,hideProgressBar:!1,closeOnClick:!0,pauseOnHover:!0,draggable:!0,progress:void 0,theme:"light"})},error:function(){return o.Am.error("Transaction Error!",{position:"bottom-center",autoClose:4e3,hideProgressBar:!1,closeOnClick:!0,pauseOnHover:!0,draggable:!0,progress:void 0,theme:"light"})},toastContainer:(0,l.jsx)(o.Ix,{position:"bottom-center",autoClose:5e3,hideProgressBar:!1,newestOnTop:!0,closeOnClick:!0,rtl:!1,pauseOnFocusLoss:!0,draggable:!0,pauseOnHover:!0,theme:"light"})}}var u=n(74165),m=n(15861);function x(){var e=(0,r.cqn)("0x8d556299531B2dCE5A3c448E22Fafc346d004B61");return{contract:e.contract,isLoading:e.isLoading}}var h=n(85068);function j(){return(0,l.jsx)(l.Fragment,{children:(0,l.jsx)(h.Z,{animation:"border",variant:"secondary",size:"sm",children:(0,l.jsx)("span",{className:"visually-hidden",children:"Loading..."})})})}function g(){var e=function(){var e=x(),t=e.contract,n=e.isLoading,r=(0,i.useState)(0),a=(0,s.Z)(r,2),l=a[0],c=a[1];return(0,i.useEffect)((function(){(0,m.Z)((0,u.Z)().mark((function e(){return(0,u.Z)().wrap((function(e){for(;;)switch(e.prev=e.next){case 0:if(e.t0=c,!n){e.next=5;break}e.t1=0,e.next=8;break;case 5:return e.next=7,t.erc721.totalCount();case 7:e.t1=e.sent.toNumber(Int32Array);case 8:e.t2=e.t1,(0,e.t0)(e.t2);case 10:case"end":return e.stop()}}),e)})))()})),{supply:l,isLoading:n}}(),t=e.supply,n=0===t?(0,l.jsx)(j,{}):t;return(0,l.jsx)(l.Fragment,{children:(0,l.jsxs)("label",{children:["Total Supply: ",(0,l.jsx)("b",{children:n})," G Minions"]})})}function f(){var e=function(){var e=x(),t=e.contract,n=e.isLoading,r=(0,i.useState)(0),a=(0,s.Z)(r,2),l=a[0],c=a[1];return(0,i.useEffect)((function(){(0,m.Z)((0,u.Z)().mark((function e(){return(0,u.Z)().wrap((function(e){for(;;)switch(e.prev=e.next){case 0:if(e.t0=c,!n){e.next=5;break}e.t1=0,e.next=8;break;case 5:return e.next=7,t.erc721.totalUnclaimedSupply();case 7:e.t1=e.sent.toNumber(Int32Array);case 8:e.t2=e.t1,(0,e.t0)(e.t2);case 10:case"end":return e.stop()}}),e)})))()})),{supply:l}}(),t=e.supply,n=0===t?(0,l.jsx)(j,{}):t;return(0,l.jsx)(l.Fragment,{children:(0,l.jsxs)("label",{children:["Unclaimed Supply:"," ",(0,l.jsx)("b",{className:"data-style count-color",children:n})]})})}function p(){var e=x().contract,t=(0,r.Mb8)(e);return{data:t.data,isLoading:t.isLoading,error:t.error}}function y(){var e=p(),t=e.data,n=e.isLoading,s=e.error,r=n?(0,l.jsx)(j,{}):null!=s?s.toString():t.maxClaimableSupply;return(0,l.jsx)(l.Fragment,{children:(0,l.jsxs)("label",{children:["Private Mint Supply:"," ",(0,l.jsx)("b",{className:"data-style count-color",children:r})]})})}function b(){var e=p(),t=e.data,n=e.isLoading,s=e.error,r=n?(0,l.jsx)(j,{}):null!=s?s.toString():t.currentMintSupply;return(0,l.jsx)(l.Fragment,{children:(0,l.jsxs)("label",{children:["Minted in Current Event:"," ",(0,l.jsx)("b",{className:"data-style count-color",children:r})]})})}function v(){var e=function(){var e=x().contract,t=(0,r.Mtw)(e);return{data:t.data,isLoading:t.isLoading,error:t.error}}(),t=e.data,n=e.isLoading,s=e.error,a=n?(0,l.jsx)(j,{}):null!=s?s.toString():t.toNumber(Int32Array);return(0,l.jsx)(l.Fragment,{children:(0,l.jsxs)("label",{children:["Minted in Total: ",(0,l.jsx)("b",{className:"data-style count-color",children:a})]})})}function N(){var e=p(),t=e.data,n=e.isLoading,s=e.error,r=(n?(0,l.jsx)(j,{}):null!=s?s.toString():t.price.toBigInt()).toString(),a=n||(null!=s?s.toString():t.currencyMetadata.symbol),i=n?(0,l.jsx)(j,{}):null!=s?s.toString():t.maxClaimablePerWallet,c=n?(0,l.jsx)(j,{}):null!=s?s.toString():r.length>1?r[0]+"."+r[1]+r[2]+" "+a:"FREE";return(0,l.jsxs)(l.Fragment,{children:[(0,l.jsxs)("label",{children:["Max Claim Per Wallet:"," ",(0,l.jsx)("b",{className:"data-style count-color",children:i})]}),(0,l.jsx)("br",{}),(0,l.jsxs)("label",{children:["Mint Price: ",(0,l.jsx)("b",{className:"data-style count-color",children:c})]})]})}function w(){return{address:(0,r.SFn)()}}function F(){var e=w().address,t=x().contract,n=(0,r.wb9)(t,{walletAddress:e||"",quantity:1}),s=n.data,a=n.isLoading?(0,l.jsx)("div",{className:"data-style eligibility",children:(0,l.jsx)("label",{children:(0,l.jsx)(j,{})})}):s.length>0?(0,l.jsx)("div",{className:"data-style eligibility negative",children:(0,l.jsx)("label",{children:"You are not allowed to claim"})}):0===s.length?(0,l.jsx)("div",{className:"data-style eligibility positive",children:(0,l.jsx)("label",{children:"Available to Claim"})}):(0,l.jsx)("div",{className:"data-style eligibility negative",children:(0,l.jsx)("label",{children:"You are not allowed to claim"})});return(0,l.jsx)(l.Fragment,{children:a})}var C=n(2135);function k(){var e=d(),t=e.submit,n=e.success,a=e.error,c=function(){var e=(0,i.useState)(!1),t=(0,s.Z)(e,2),n=t[0],r=t[1],a=(0,i.useState)(!1),c=(0,s.Z)(a,2),o=c[0],d=c[1];return{termsOfUse:o,privacyPolicy:n,inputs:(0,l.jsxs)(l.Fragment,{children:[(0,l.jsx)("hr",{className:"my-2 fonts-style eligibility"}),(0,l.jsxs)("div",{className:"fonts",children:[(0,l.jsxs)("div",{className:"form-check text-opacity-75",children:[(0,l.jsx)("input",{className:"form-check-input fonts-style eligibility",type:"checkbox",onChange:function(e){r(e.target.checked)}}),(0,l.jsxs)("label",{className:"form-check-label fonts-style eligibility agreements",children:["Agree with ",(0,l.jsx)(C.rU,{className:"text-decoration-none",to:"/privacy-policy",children:"Privacy Policy"})]})]}),(0,l.jsxs)("div",{className:"form-check text-opacity-75",children:[(0,l.jsx)("input",{className:"form-check-input fonts-style eligibility",type:"checkbox",onChange:function(e){d(e.target.checked)}}),(0,l.jsxs)("label",{className:"form-check-label fonts-style eligibility agreements",children:["Agree with ",(0,l.jsx)(C.rU,{className:"text-decoration-none",to:"/terms-of-use",children:"Terms Of Use"})]})]})]})]})}}(),o=c.inputs,u=c.termsOfUse,m=c.privacyPolicy,h={output:(0,l.jsx)(l.Fragment,{children:(0,l.jsx)("div",{className:"conditions",children:(0,l.jsx)("label",{children:"Please Read and Agree with Privacy policy and Terms of Use."})})})}.output,g=function(){var e=x().contract,t=w().address,n=(0,r.wb9)(e,{walletAddress:t||"",quantity:1});return{data:n.data,isLoading:n.isLoading,error:n.error}}(),f=g.data,p=g.isLoading,y=p?(0,l.jsxs)(l.Fragment,{children:[(0,l.jsx)("div",{className:"conditions",children:(0,l.jsx)(j,{})}),o]}):u&&m?f.length>0&&!p?(0,l.jsxs)(l.Fragment,{children:[(0,l.jsx)("div",{className:"d-flex flex-wrap justify-content-center",children:(0,l.jsx)("label",{className:"not-allowed-to-claim-pl button",children:"Not allowed"})}),o]}):(0,l.jsxs)(l.Fragment,{children:[(0,l.jsx)("div",{className:"d-flex flex-wrap justify-content-center",children:(0,l.jsx)(r.tnh,{dropdownPosition:{side:"bottom",align:"center"},contractAddress:"0x8d556299531B2dCE5A3c448E22Fafc346d004B61",action:function(e){return e.erc721.claim(1)},onSuccess:n,onSubmit:t,onError:a,className:"claim-pl button",children:"Claim NFT"})}),o]}):(0,l.jsxs)(l.Fragment,{children:[h,o]});return(0,l.jsx)(l.Fragment,{children:y})}function S(){return(0,l.jsxs)(l.Fragment,{children:[(0,l.jsxs)("div",{className:"data",children:[(0,l.jsx)("div",{className:"data-style total-supply",children:(0,l.jsx)(g,{})}),(0,l.jsxs)("div",{className:"data-style eligibility ",children:[(0,l.jsx)("div",{className:"data-style common-data",children:(0,l.jsx)(f,{})}),(0,l.jsx)("div",{className:"data-style common-data",children:(0,l.jsx)(y,{})}),(0,l.jsx)("div",{className:"data-style common-data",children:(0,l.jsx)(b,{})}),(0,l.jsx)("div",{className:"data-style common-data",children:(0,l.jsx)(v,{})})]}),(0,l.jsx)("div",{children:(0,l.jsx)(F,{})}),(0,l.jsx)("div",{className:"data-style price",children:(0,l.jsx)(N,{})})]}),(0,l.jsx)(k,{})]})}function L(){return(0,l.jsx)(l.Fragment,{children:(0,l.jsx)(P,{})})}function P(){var e=d().toastContainer;return(0,l.jsx)("div",{className:"container col-xl-10 mb-sm-5 my-md-0 mb-lg-5 mb-xl-5 py-1 ",children:(0,l.jsxs)("div",{className:"row align-items-center my-sm-1 my-md-0 my-lg-2 g-lg-4 py-3 mb-2",children:[(0,l.jsx)(c,{}),(0,l.jsxs)("div",{className:"col-md-10 mx-auto col-lg-4 my-sm-1 my-md-3 my-lg-0 my-xl-5 card py-3",children:[(0,l.jsx)("form",{className:"p-sm-0 p-md-2 p-lg-2 p-xl-2 mx-auto",onSubmit:function(e){e.preventDefault()},children:(0,l.jsx)(S,{})}),e]})]})})}n(6320);function A(){return(0,l.jsx)(l.Fragment,{children:(0,l.jsx)("div",{className:"container welcome-screen",children:(0,l.jsx)("div",{className:"row welcome-screen text",children:(0,l.jsx)("div",{children:(0,l.jsx)("p",{children:"Please Connect your wallet in order to continue"})})})})})}function O(){var e=(0,i.useState)(!1),t=(0,s.Z)(e,2),n=t[0],c=t[1];document.title="Jax World - Mint",(0,i.useEffect)((function(){c(!0),setTimeout((function(){c(!1)}),1e3)}),[]);var o=(0,r.pX8)();return n?(0,l.jsxs)("div",{children:[(0,l.jsx)(a.I,{})," "]}):(0,l.jsx)(l.Fragment,{children:"connected"===o?(0,l.jsx)(l.Fragment,{children:(0,l.jsx)(L,{})}):"disconnected"===o?(0,l.jsx)(l.Fragment,{children:(0,l.jsx)(A,{})}):(0,l.jsx)(l.Fragment,{children:(0,l.jsx)(a.I,{})})})}}}]);