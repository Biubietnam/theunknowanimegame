using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D5F RID: 3423
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RacingData : IMessage<RacingData>, IMessage, IEquatable<RacingData>, IDeepCloneable<RacingData>, IBufferMessage
	{
		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x060098F0 RID: 39152 RVA: 0x0019734F File Offset: 0x0019554F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingData> Parser
		{
			get
			{
				return RacingData._parser;
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x060098F1 RID: 39153 RVA: 0x00197356 File Offset: 0x00195556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RacingDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x060098F2 RID: 39154 RVA: 0x00197368 File Offset: 0x00195568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingData.Descriptor;
			}
		}

		// Token: 0x060098F3 RID: 39155 RVA: 0x0019736F File Offset: 0x0019556F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingData()
		{
		}

		// Token: 0x060098F4 RID: 39156 RVA: 0x00197378 File Offset: 0x00195578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingData(RacingData other) : this()
		{
			this.type_ = other.type_;
			this.level_ = other.level_;
			this.oKKPIDHMCIP_ = other.oKKPIDHMCIP_;
			this.lFNCPMMHLCO_ = other.lFNCPMMHLCO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098F5 RID: 39157 RVA: 0x001973CC File Offset: 0x001955CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingData Clone()
		{
			return new RacingData(this);
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x060098F6 RID: 39158 RVA: 0x001973D4 File Offset: 0x001955D4
		// (set) Token: 0x060098F7 RID: 39159 RVA: 0x001973DC File Offset: 0x001955DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovieRacingType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x060098F8 RID: 39160 RVA: 0x001973E5 File Offset: 0x001955E5
		// (set) Token: 0x060098F9 RID: 39161 RVA: 0x001973ED File Offset: 0x001955ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x060098FA RID: 39162 RVA: 0x001973F6 File Offset: 0x001955F6
		// (set) Token: 0x060098FB RID: 39163 RVA: 0x001973FE File Offset: 0x001955FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKKPIDHMCIP
		{
			get
			{
				return this.oKKPIDHMCIP_;
			}
			set
			{
				this.oKKPIDHMCIP_ = value;
			}
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x060098FC RID: 39164 RVA: 0x00197407 File Offset: 0x00195607
		// (set) Token: 0x060098FD RID: 39165 RVA: 0x0019740F File Offset: 0x0019560F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LFNCPMMHLCO
		{
			get
			{
				return this.lFNCPMMHLCO_;
			}
			set
			{
				this.lFNCPMMHLCO_ = value;
			}
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x00197418 File Offset: 0x00195618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingData);
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x00197428 File Offset: 0x00195628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingData other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Level == other.Level && this.OKKPIDHMCIP == other.OKKPIDHMCIP && this.LFNCPMMHLCO == other.LFNCPMMHLCO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x00197494 File Offset: 0x00195694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != MovieRacingType.MovieRacingOverTake)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.OKKPIDHMCIP != 0U)
			{
				num ^= this.OKKPIDHMCIP.GetHashCode();
			}
			if (this.LFNCPMMHLCO != 0U)
			{
				num ^= this.LFNCPMMHLCO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009901 RID: 39169 RVA: 0x00197524 File Offset: 0x00195724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x0019752C File Offset: 0x0019572C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x00197538 File Offset: 0x00195738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Level);
			}
			if (this.LFNCPMMHLCO != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.LFNCPMMHLCO);
			}
			if (this.OKKPIDHMCIP != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.OKKPIDHMCIP);
			}
			if (this.Type != MovieRacingType.MovieRacingOverTake)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x001975CC File Offset: 0x001957CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != MovieRacingType.MovieRacingOverTake)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.OKKPIDHMCIP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OKKPIDHMCIP);
			}
			if (this.LFNCPMMHLCO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LFNCPMMHLCO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009905 RID: 39173 RVA: 0x00197654 File Offset: 0x00195854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != MovieRacingType.MovieRacingOverTake)
			{
				this.Type = other.Type;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.OKKPIDHMCIP != 0U)
			{
				this.OKKPIDHMCIP = other.OKKPIDHMCIP;
			}
			if (other.LFNCPMMHLCO != 0U)
			{
				this.LFNCPMMHLCO = other.LFNCPMMHLCO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009906 RID: 39174 RVA: 0x001976CC File Offset: 0x001958CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009907 RID: 39175 RVA: 0x001976D8 File Offset: 0x001958D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 48U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.LFNCPMMHLCO = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.OKKPIDHMCIP = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Type = (MovieRacingType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B65 RID: 15205
		private static readonly MessageParser<RacingData> _parser = new MessageParser<RacingData>(() => new RacingData());

		// Token: 0x04003B66 RID: 15206
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B67 RID: 15207
		public const int TypeFieldNumber = 14;

		// Token: 0x04003B68 RID: 15208
		private MovieRacingType type_;

		// Token: 0x04003B69 RID: 15209
		public const int LevelFieldNumber = 6;

		// Token: 0x04003B6A RID: 15210
		private uint level_;

		// Token: 0x04003B6B RID: 15211
		public const int OKKPIDHMCIPFieldNumber = 10;

		// Token: 0x04003B6C RID: 15212
		private uint oKKPIDHMCIP_;

		// Token: 0x04003B6D RID: 15213
		public const int LFNCPMMHLCOFieldNumber = 9;

		// Token: 0x04003B6E RID: 15214
		private uint lFNCPMMHLCO_;
	}
}
