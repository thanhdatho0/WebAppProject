interface navigateItem{
    caption: string,
    href: string,
}

type Props = {
    title: string
    navigateItems: navigateItem[]
}

const AdditionInfo = (info: Props) => {
  return (
    <div>
        <h4 className='footer-title'>{info.title}</h4>
        <ul>
            {info.navigateItems.map((item) => 
            <li>
                <a href={item.href}>{item.caption}</a>
            </li>)}
        </ul>
    </div>
  )
}

export default AdditionInfo