<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html">
	</xsl:output>
	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<th>Genre</th>
						<th>BandName</th>
						<th>Album</th>
						<th>SongName</th>
						<th>Duration</th>
						<th>ReleaseYear</th>
					</tr>
					<xsl:for-each select="SongDataBase/song">
						<tr>
							<td>
								<xsl:value-of select="@Genre">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@BandName">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Album">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@SongName">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Duration">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@ReleaseYear">
								</xsl:value-of>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>