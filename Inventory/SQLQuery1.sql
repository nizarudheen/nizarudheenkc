select item.it_code,purchase_stock.p_stock.sale_stock.s_stock,(isnull(purchase_stock.p_stock,0)-isnull(sales_stock.s_stock,0)) as currentstock from item left outer join (select prd_item_code,sum(isnull(prd_quantity,0))as p_stock from purchase_detail group by prd_item_code) as purchase_stock on item.it_code=purchase_stock.prd_item_code left outer join (select sd_item_code,sum(isnull(sd_quantity,0)) as s_stock from sale_detail group by sd_item_code) as sales_stock on item.it_code=sales_stock.sd_item_code

select item.it_code,isnull(purchase_stock.p_stock,0)as p_stock,isnull(sale_stock.s_stock,0)as s_stock,(isnull(purchase_stock.p_stock,0)-isnull(sale_stock.s_stock,0)) as currentstock from item left outer join (select prd_item_code,sum(isnull(prd_quantity,0)) as p_stock from purchase_detail group by prd_item_code) as purchase_stock on item.it_code=purchase_stock.prd_item_code left outer join (select sum(isnull(sd_quantity,0)) as s_stock,sd_item_code from sale_detail group by sd_item_code) as sale_stock on item.it_code=sale_stock.sd_item_code


select item.it_name,item.it_code,s.saled from item left outer join (select sum(isnull(sd_quantity,0)) as saled,sd_item_code from sale_detail )as s on item.it_code=s.sd_item_code order by s.saled




select * from sale_detail where bill_no=15