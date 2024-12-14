using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200017B RID: 379
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CellInfo : IMessage<CellInfo>, IMessage, IEquatable<CellInfo>, IDeepCloneable<CellInfo>, IBufferMessage
	{
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00030D7F File Offset: 0x0002EF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CellInfo> Parser
		{
			get
			{
				return CellInfo._parser;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00030D86 File Offset: 0x0002EF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CellInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00030D98 File Offset: 0x0002EF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CellInfo.Descriptor;
			}
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00030D9F File Offset: 0x0002EF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellInfo()
		{
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellInfo(CellInfo other) : this()
		{
			this.cellList_ = other.cellList_.Clone();
			this.dNONEOAMOGC_ = other.dNONEOAMOGC_;
			this.oEGJHMLMFDN_ = other.oEGJHMLMFDN_;
			this.bAGAPGFKEHC_ = other.bAGAPGFKEHC_;
			this.hIFJGMCALOO_ = other.hIFJGMCALOO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00030E19 File Offset: 0x0002F019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellInfo Clone()
		{
			return new CellInfo(this);
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00030E21 File Offset: 0x0002F021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueCell> CellList
		{
			get
			{
				return this.cellList_;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x00030E29 File Offset: 0x0002F029
		// (set) Token: 0x060010EF RID: 4335 RVA: 0x00030E31 File Offset: 0x0002F031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DNONEOAMOGC
		{
			get
			{
				return this.dNONEOAMOGC_;
			}
			set
			{
				this.dNONEOAMOGC_ = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x00030E3A File Offset: 0x0002F03A
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00030E42 File Offset: 0x0002F042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OEGJHMLMFDN
		{
			get
			{
				return this.oEGJHMLMFDN_;
			}
			set
			{
				this.oEGJHMLMFDN_ = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00030E4B File Offset: 0x0002F04B
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x00030E53 File Offset: 0x0002F053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BAGAPGFKEHC
		{
			get
			{
				return this.bAGAPGFKEHC_;
			}
			set
			{
				this.bAGAPGFKEHC_ = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00030E5C File Offset: 0x0002F05C
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00030E64 File Offset: 0x0002F064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HIFJGMCALOO
		{
			get
			{
				return this.hIFJGMCALOO_;
			}
			set
			{
				this.hIFJGMCALOO_ = value;
			}
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00030E6D File Offset: 0x0002F06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CellInfo);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00030E7C File Offset: 0x0002F07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CellInfo other)
		{
			return other != null && (other == this || (this.cellList_.Equals(other.cellList_) && this.DNONEOAMOGC == other.DNONEOAMOGC && this.OEGJHMLMFDN == other.OEGJHMLMFDN && this.BAGAPGFKEHC == other.BAGAPGFKEHC && this.HIFJGMCALOO == other.HIFJGMCALOO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00030EFC File Offset: 0x0002F0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cellList_.GetHashCode();
			if (this.DNONEOAMOGC != 0U)
			{
				num ^= this.DNONEOAMOGC.GetHashCode();
			}
			if (this.OEGJHMLMFDN != 0U)
			{
				num ^= this.OEGJHMLMFDN.GetHashCode();
			}
			if (this.BAGAPGFKEHC != 0U)
			{
				num ^= this.BAGAPGFKEHC.GetHashCode();
			}
			if (this.HIFJGMCALOO != 0U)
			{
				num ^= this.HIFJGMCALOO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00030F94 File Offset: 0x0002F194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00030F9C File Offset: 0x0002F19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00030FA8 File Offset: 0x0002F1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BAGAPGFKEHC != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BAGAPGFKEHC);
			}
			if (this.HIFJGMCALOO != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.HIFJGMCALOO);
			}
			if (this.OEGJHMLMFDN != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.OEGJHMLMFDN);
			}
			this.cellList_.WriteTo(ref output, CellInfo._repeated_cellList_codec);
			if (this.DNONEOAMOGC != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.DNONEOAMOGC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0003104C File Offset: 0x0002F24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cellList_.CalculateSize(CellInfo._repeated_cellList_codec);
			if (this.DNONEOAMOGC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DNONEOAMOGC);
			}
			if (this.OEGJHMLMFDN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OEGJHMLMFDN);
			}
			if (this.BAGAPGFKEHC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BAGAPGFKEHC);
			}
			if (this.HIFJGMCALOO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HIFJGMCALOO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x000310E8 File Offset: 0x0002F2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CellInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.cellList_.Add(other.cellList_);
			if (other.DNONEOAMOGC != 0U)
			{
				this.DNONEOAMOGC = other.DNONEOAMOGC;
			}
			if (other.OEGJHMLMFDN != 0U)
			{
				this.OEGJHMLMFDN = other.OEGJHMLMFDN;
			}
			if (other.BAGAPGFKEHC != 0U)
			{
				this.BAGAPGFKEHC = other.BAGAPGFKEHC;
			}
			if (other.HIFJGMCALOO != 0U)
			{
				this.HIFJGMCALOO = other.HIFJGMCALOO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00031171 File Offset: 0x0002F371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0003117C File Offset: 0x0002F37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.BAGAPGFKEHC = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.HIFJGMCALOO = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.OEGJHMLMFDN = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						this.cellList_.AddEntriesFrom(ref input, CellInfo._repeated_cellList_codec);
						continue;
					}
					if (num == 80U)
					{
						this.DNONEOAMOGC = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000711 RID: 1809
		private static readonly MessageParser<CellInfo> _parser = new MessageParser<CellInfo>(() => new CellInfo());

		// Token: 0x04000712 RID: 1810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000713 RID: 1811
		public const int CellListFieldNumber = 9;

		// Token: 0x04000714 RID: 1812
		private static readonly FieldCodec<ChessRogueCell> _repeated_cellList_codec = FieldCodec.ForMessage<ChessRogueCell>(74U, ChessRogueCell.Parser);

		// Token: 0x04000715 RID: 1813
		private readonly RepeatedField<ChessRogueCell> cellList_ = new RepeatedField<ChessRogueCell>();

		// Token: 0x04000716 RID: 1814
		public const int DNONEOAMOGCFieldNumber = 10;

		// Token: 0x04000717 RID: 1815
		private uint dNONEOAMOGC_;

		// Token: 0x04000718 RID: 1816
		public const int OEGJHMLMFDNFieldNumber = 5;

		// Token: 0x04000719 RID: 1817
		private uint oEGJHMLMFDN_;

		// Token: 0x0400071A RID: 1818
		public const int BAGAPGFKEHCFieldNumber = 2;

		// Token: 0x0400071B RID: 1819
		private uint bAGAPGFKEHC_;

		// Token: 0x0400071C RID: 1820
		public const int HIFJGMCALOOFieldNumber = 3;

		// Token: 0x0400071D RID: 1821
		private uint hIFJGMCALOO_;
	}
}
