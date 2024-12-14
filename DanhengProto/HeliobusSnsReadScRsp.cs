using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008D5 RID: 2261
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSnsReadScRsp : IMessage<HeliobusSnsReadScRsp>, IMessage, IEquatable<HeliobusSnsReadScRsp>, IDeepCloneable<HeliobusSnsReadScRsp>, IBufferMessage
	{
		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x060064D0 RID: 25808 RVA: 0x0010DC04 File Offset: 0x0010BE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSnsReadScRsp> Parser
		{
			get
			{
				return HeliobusSnsReadScRsp._parser;
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x060064D1 RID: 25809 RVA: 0x0010DC0B File Offset: 0x0010BE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSnsReadScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x060064D2 RID: 25810 RVA: 0x0010DC1D File Offset: 0x0010BE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSnsReadScRsp.Descriptor;
			}
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x0010DC24 File Offset: 0x0010BE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsReadScRsp()
		{
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x0010DC2C File Offset: 0x0010BE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsReadScRsp(HeliobusSnsReadScRsp other) : this()
		{
			this.aLAOMAOBNFG_ = other.aLAOMAOBNFG_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x0010DC5D File Offset: 0x0010BE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsReadScRsp Clone()
		{
			return new HeliobusSnsReadScRsp(this);
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x060064D6 RID: 25814 RVA: 0x0010DC65 File Offset: 0x0010BE65
		// (set) Token: 0x060064D7 RID: 25815 RVA: 0x0010DC6D File Offset: 0x0010BE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ALAOMAOBNFG
		{
			get
			{
				return this.aLAOMAOBNFG_;
			}
			set
			{
				this.aLAOMAOBNFG_ = value;
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x060064D8 RID: 25816 RVA: 0x0010DC76 File Offset: 0x0010BE76
		// (set) Token: 0x060064D9 RID: 25817 RVA: 0x0010DC7E File Offset: 0x0010BE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x0010DC87 File Offset: 0x0010BE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSnsReadScRsp);
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x0010DC95 File Offset: 0x0010BE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSnsReadScRsp other)
		{
			return other != null && (other == this || (this.ALAOMAOBNFG == other.ALAOMAOBNFG && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x0010DCD4 File Offset: 0x0010BED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ALAOMAOBNFG != 0U)
			{
				num ^= this.ALAOMAOBNFG.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x0010DD2C File Offset: 0x0010BF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x0010DD34 File Offset: 0x0010BF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x0010DD40 File Offset: 0x0010BF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ALAOMAOBNFG != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ALAOMAOBNFG);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x0010DD9C File Offset: 0x0010BF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ALAOMAOBNFG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ALAOMAOBNFG);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x0010DDF4 File Offset: 0x0010BFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSnsReadScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ALAOMAOBNFG != 0U)
			{
				this.ALAOMAOBNFG = other.ALAOMAOBNFG;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x0010DE44 File Offset: 0x0010C044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x0010DE50 File Offset: 0x0010C050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.ALAOMAOBNFG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040026CD RID: 9933
		private static readonly MessageParser<HeliobusSnsReadScRsp> _parser = new MessageParser<HeliobusSnsReadScRsp>(() => new HeliobusSnsReadScRsp());

		// Token: 0x040026CE RID: 9934
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026CF RID: 9935
		public const int ALAOMAOBNFGFieldNumber = 8;

		// Token: 0x040026D0 RID: 9936
		private uint aLAOMAOBNFG_;

		// Token: 0x040026D1 RID: 9937
		public const int RetcodeFieldNumber = 13;

		// Token: 0x040026D2 RID: 9938
		private uint retcode_;
	}
}
