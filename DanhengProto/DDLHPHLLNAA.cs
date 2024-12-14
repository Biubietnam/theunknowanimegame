using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000363 RID: 867
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DDLHPHLLNAA : IMessage<DDLHPHLLNAA>, IMessage, IEquatable<DDLHPHLLNAA>, IDeepCloneable<DDLHPHLLNAA>, IBufferMessage
	{
		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x0006C6E8 File Offset: 0x0006A8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DDLHPHLLNAA> Parser
		{
			get
			{
				return DDLHPHLLNAA._parser;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x0006C6EF File Offset: 0x0006A8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DDLHPHLLNAAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x0006C701 File Offset: 0x0006A901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DDLHPHLLNAA.Descriptor;
			}
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x0006C708 File Offset: 0x0006A908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DDLHPHLLNAA()
		{
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x0006C710 File Offset: 0x0006A910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DDLHPHLLNAA(DDLHPHLLNAA other) : this()
		{
			this.bCFCCDMEAKO_ = other.bCFCCDMEAKO_;
			this.mJMDPFKHNEH_ = other.mJMDPFKHNEH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x0006C741 File Offset: 0x0006A941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DDLHPHLLNAA Clone()
		{
			return new DDLHPHLLNAA(this);
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x0006C749 File Offset: 0x0006A949
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x0006C751 File Offset: 0x0006A951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BCFCCDMEAKO
		{
			get
			{
				return this.bCFCCDMEAKO_;
			}
			set
			{
				this.bCFCCDMEAKO_ = value;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x0006C75A File Offset: 0x0006A95A
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x0006C762 File Offset: 0x0006A962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MJMDPFKHNEH
		{
			get
			{
				return this.mJMDPFKHNEH_;
			}
			set
			{
				this.mJMDPFKHNEH_ = value;
			}
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0006C76B File Offset: 0x0006A96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DDLHPHLLNAA);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0006C779 File Offset: 0x0006A979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DDLHPHLLNAA other)
		{
			return other != null && (other == this || (this.BCFCCDMEAKO == other.BCFCCDMEAKO && this.MJMDPFKHNEH == other.MJMDPFKHNEH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0006C7B8 File Offset: 0x0006A9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BCFCCDMEAKO != 0U)
			{
				num ^= this.BCFCCDMEAKO.GetHashCode();
			}
			if (this.MJMDPFKHNEH != 0U)
			{
				num ^= this.MJMDPFKHNEH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0006C810 File Offset: 0x0006AA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x0006C818 File Offset: 0x0006AA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x0006C824 File Offset: 0x0006AA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BCFCCDMEAKO != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.BCFCCDMEAKO);
			}
			if (this.MJMDPFKHNEH != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.MJMDPFKHNEH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0006C880 File Offset: 0x0006AA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BCFCCDMEAKO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BCFCCDMEAKO);
			}
			if (this.MJMDPFKHNEH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MJMDPFKHNEH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x0006C8D8 File Offset: 0x0006AAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DDLHPHLLNAA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BCFCCDMEAKO != 0U)
			{
				this.BCFCCDMEAKO = other.BCFCCDMEAKO;
			}
			if (other.MJMDPFKHNEH != 0U)
			{
				this.MJMDPFKHNEH = other.MJMDPFKHNEH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x0006C928 File Offset: 0x0006AB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x0006C934 File Offset: 0x0006AB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MJMDPFKHNEH = input.ReadUInt32();
					}
				}
				else
				{
					this.BCFCCDMEAKO = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000FA5 RID: 4005
		private static readonly MessageParser<DDLHPHLLNAA> _parser = new MessageParser<DDLHPHLLNAA>(() => new DDLHPHLLNAA());

		// Token: 0x04000FA6 RID: 4006
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FA7 RID: 4007
		public const int BCFCCDMEAKOFieldNumber = 6;

		// Token: 0x04000FA8 RID: 4008
		private uint bCFCCDMEAKO_;

		// Token: 0x04000FA9 RID: 4009
		public const int MJMDPFKHNEHFieldNumber = 15;

		// Token: 0x04000FAA RID: 4010
		private uint mJMDPFKHNEH_;
	}
}
