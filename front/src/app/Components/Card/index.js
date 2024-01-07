import styles from './card.module.css';
import 'bootstrap/dist/css/bootstrap.min.css';
process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0';


export default async function Card() {
	const passagem = await fetch(' http://localhost:5129/api/passagem').then(res => res.json());
	 console.log(passagem);  

	
	return (
		<div key={passagem.id}className={styles.container}>
			{passagem?.map((passagem) => (
				
				<div className="card" style={{ width: "18rem" }}>
				<div className="card-body">
				<h5 className="card-title" style={{ textAlign: "center" }}>{passagem.agencia}</h5>
				
				<div> 
					<p suppressHydrationWarning className="card-text" >
					<h5 suppressHydrationWarning>DATA DE IDA:</h5>{passagem.ida}
				</p>	
				</div>
				
				<div>
					<p className="card-text">
					<h5 suppressHydrationWarning>DATA DE VOLTA:</h5>{passagem.volta}
				</p>
				</div>
				
				<div>
					<p suppressHydrationWarning className="card-text">
					<h5 suppressHydrationWarning>ORIGEM:</h5>{passagem.origem}
				</p>
				</div>
				
				<div>
				<p suppressHydrationWarning className="card-text">
					<h5 suppressHydrationWarning>DESTINO:</h5>{passagem.destino}
				</p>
				</div>
				
				<div>
				<p suppressHydrationWarning className="card-text">
					<h5 suppressHydrationWarning>QUANTIDADE DE LUGARES:</h5>{passagem.lugares}
				</p>
				</div>			
				
				</div>
				</div>
 
			))}
		</div>
	)
}


