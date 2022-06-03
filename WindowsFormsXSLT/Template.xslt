<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">

		<table border="1" width="100%">

			<tr>
				<td>№</td>
				<td>Назва</td>
				<td>Ціна</td>
				<td>Валюта</td>
				<td>Виробник</td>
			</tr>
			
			<xsl:for-each select="root/item">

				<tr>
					<td>
						<xsl:value-of select="@index"/>
					</td>
					<td>
						<xsl:value-of select="name"/>
					</td>
					<td>
						<xsl:value-of select="price"/>
					</td>
					<td>
						<xsl:value-of select="currency"/>
					</td>
					<td>
						<xsl:value-of select="manufacturer"/>
					</td>
				</tr>
				
			</xsl:for-each>
			
		</table>	
		
    </xsl:template>
	
</xsl:stylesheet>
