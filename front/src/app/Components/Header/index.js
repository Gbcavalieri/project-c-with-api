import Link from 'next/link'


export default function Header() {
	return (
		
		<header className="header">
			<link rel="shortcut icon" href="airplane.ico" type="image/x-icon"></link>
			<div className="nav__logo"> <span className="logo-title"> Road of Dreams.</span></div>
		
			<ul>
				<li>
				<Link href="/API">	<button class="btn btn-outline-primary btn-lg bg-primary text-white" >Passagens</button></Link>
				</li>
				
				
			</ul>
	
		</header>
	)
}