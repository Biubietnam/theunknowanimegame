using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000887 RID: 2183
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HAKAOKNJJDL : IMessage<HAKAOKNJJDL>, IMessage, IEquatable<HAKAOKNJJDL>, IDeepCloneable<HAKAOKNJJDL>, IBufferMessage
	{
		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06006114 RID: 24852 RVA: 0x001008E9 File Offset: 0x000FEAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HAKAOKNJJDL> Parser
		{
			get
			{
				return HAKAOKNJJDL._parser;
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06006115 RID: 24853 RVA: 0x001008F0 File Offset: 0x000FEAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HAKAOKNJJDLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06006116 RID: 24854 RVA: 0x00100902 File Offset: 0x000FEB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HAKAOKNJJDL.Descriptor;
			}
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x00100909 File Offset: 0x000FEB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HAKAOKNJJDL()
		{
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x0010091C File Offset: 0x000FEB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HAKAOKNJJDL(HAKAOKNJJDL other) : this()
		{
			this.lFHCJIBBMHB_ = other.lFHCJIBBMHB_.Clone();
			this.dLHJPCFNALI_ = other.dLHJPCFNALI_;
			this.gFFCKCINHHP_ = other.gFFCKCINHHP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x00100969 File Offset: 0x000FEB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HAKAOKNJJDL Clone()
		{
			return new HAKAOKNJJDL(this);
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x0600611A RID: 24858 RVA: 0x00100971 File Offset: 0x000FEB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LFHCJIBBMHB
		{
			get
			{
				return this.lFHCJIBBMHB_;
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x0600611B RID: 24859 RVA: 0x00100979 File Offset: 0x000FEB79
		// (set) Token: 0x0600611C RID: 24860 RVA: 0x00100981 File Offset: 0x000FEB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DLHJPCFNALI
		{
			get
			{
				return this.dLHJPCFNALI_;
			}
			set
			{
				this.dLHJPCFNALI_ = value;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x0600611D RID: 24861 RVA: 0x0010098A File Offset: 0x000FEB8A
		// (set) Token: 0x0600611E RID: 24862 RVA: 0x00100992 File Offset: 0x000FEB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GFFCKCINHHP
		{
			get
			{
				return this.gFFCKCINHHP_;
			}
			set
			{
				this.gFFCKCINHHP_ = value;
			}
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x0010099B File Offset: 0x000FEB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HAKAOKNJJDL);
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x001009AC File Offset: 0x000FEBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HAKAOKNJJDL other)
		{
			return other != null && (other == this || (this.lFHCJIBBMHB_.Equals(other.lFHCJIBBMHB_) && this.DLHJPCFNALI == other.DLHJPCFNALI && this.GFFCKCINHHP == other.GFFCKCINHHP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x00100A0C File Offset: 0x000FEC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lFHCJIBBMHB_.GetHashCode();
			if (this.DLHJPCFNALI != 0U)
			{
				num ^= this.DLHJPCFNALI.GetHashCode();
			}
			if (this.GFFCKCINHHP != 0U)
			{
				num ^= this.GFFCKCINHHP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x00100A72 File Offset: 0x000FEC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x00100A7A File Offset: 0x000FEC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x00100A84 File Offset: 0x000FEC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lFHCJIBBMHB_.WriteTo(ref output, HAKAOKNJJDL._repeated_lFHCJIBBMHB_codec);
			if (this.DLHJPCFNALI != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.DLHJPCFNALI);
			}
			if (this.GFFCKCINHHP != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GFFCKCINHHP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x00100AF0 File Offset: 0x000FECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lFHCJIBBMHB_.CalculateSize(HAKAOKNJJDL._repeated_lFHCJIBBMHB_codec);
			if (this.DLHJPCFNALI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DLHJPCFNALI);
			}
			if (this.GFFCKCINHHP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GFFCKCINHHP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x00100B5C File Offset: 0x000FED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HAKAOKNJJDL other)
		{
			if (other == null)
			{
				return;
			}
			this.lFHCJIBBMHB_.Add(other.lFHCJIBBMHB_);
			if (other.DLHJPCFNALI != 0U)
			{
				this.DLHJPCFNALI = other.DLHJPCFNALI;
			}
			if (other.GFFCKCINHHP != 0U)
			{
				this.GFFCKCINHHP = other.GFFCKCINHHP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x00100BBD File Offset: 0x000FEDBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x00100BC8 File Offset: 0x000FEDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.lFHCJIBBMHB_.AddEntriesFrom(ref input, HAKAOKNJJDL._repeated_lFHCJIBBMHB_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.DLHJPCFNALI = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.GFFCKCINHHP = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400254A RID: 9546
		private static readonly MessageParser<HAKAOKNJJDL> _parser = new MessageParser<HAKAOKNJJDL>(() => new HAKAOKNJJDL());

		// Token: 0x0400254B RID: 9547
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400254C RID: 9548
		public const int LFHCJIBBMHBFieldNumber = 3;

		// Token: 0x0400254D RID: 9549
		private static readonly FieldCodec<uint> _repeated_lFHCJIBBMHB_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x0400254E RID: 9550
		private readonly RepeatedField<uint> lFHCJIBBMHB_ = new RepeatedField<uint>();

		// Token: 0x0400254F RID: 9551
		public const int DLHJPCFNALIFieldNumber = 12;

		// Token: 0x04002550 RID: 9552
		private uint dLHJPCFNALI_;

		// Token: 0x04002551 RID: 9553
		public const int GFFCKCINHHPFieldNumber = 14;

		// Token: 0x04002552 RID: 9554
		private uint gFFCKCINHHP_;
	}
}
