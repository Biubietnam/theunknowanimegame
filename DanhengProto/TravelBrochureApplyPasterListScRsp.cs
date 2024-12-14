using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200136F RID: 4975
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureApplyPasterListScRsp : IMessage<TravelBrochureApplyPasterListScRsp>, IMessage, IEquatable<TravelBrochureApplyPasterListScRsp>, IDeepCloneable<TravelBrochureApplyPasterListScRsp>, IBufferMessage
	{
		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x0600DDF2 RID: 56818 RVA: 0x0024EE8B File Offset: 0x0024D08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureApplyPasterListScRsp> Parser
		{
			get
			{
				return TravelBrochureApplyPasterListScRsp._parser;
			}
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x0600DDF3 RID: 56819 RVA: 0x0024EE92 File Offset: 0x0024D092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureApplyPasterListScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x0600DDF4 RID: 56820 RVA: 0x0024EEA4 File Offset: 0x0024D0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureApplyPasterListScRsp.Descriptor;
			}
		}

		// Token: 0x0600DDF5 RID: 56821 RVA: 0x0024EEAB File Offset: 0x0024D0AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterListScRsp()
		{
		}

		// Token: 0x0600DDF6 RID: 56822 RVA: 0x0024EEB4 File Offset: 0x0024D0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterListScRsp(TravelBrochureApplyPasterListScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.gKAPDOCPCJM_ = ((other.gKAPDOCPCJM_ != null) ? other.gKAPDOCPCJM_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDF7 RID: 56823 RVA: 0x0024EF00 File Offset: 0x0024D100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterListScRsp Clone()
		{
			return new TravelBrochureApplyPasterListScRsp(this);
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x0600DDF8 RID: 56824 RVA: 0x0024EF08 File Offset: 0x0024D108
		// (set) Token: 0x0600DDF9 RID: 56825 RVA: 0x0024EF10 File Offset: 0x0024D110
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

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x0600DDFA RID: 56826 RVA: 0x0024EF19 File Offset: 0x0024D119
		// (set) Token: 0x0600DDFB RID: 56827 RVA: 0x0024EF21 File Offset: 0x0024D121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KHKLKHNGDOG GKAPDOCPCJM
		{
			get
			{
				return this.gKAPDOCPCJM_;
			}
			set
			{
				this.gKAPDOCPCJM_ = value;
			}
		}

		// Token: 0x0600DDFC RID: 56828 RVA: 0x0024EF2A File Offset: 0x0024D12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureApplyPasterListScRsp);
		}

		// Token: 0x0600DDFD RID: 56829 RVA: 0x0024EF38 File Offset: 0x0024D138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureApplyPasterListScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.GKAPDOCPCJM, other.GKAPDOCPCJM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDFE RID: 56830 RVA: 0x0024EF88 File Offset: 0x0024D188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.gKAPDOCPCJM_ != null)
			{
				num ^= this.GKAPDOCPCJM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DDFF RID: 56831 RVA: 0x0024EFDD File Offset: 0x0024D1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DE00 RID: 56832 RVA: 0x0024EFE5 File Offset: 0x0024D1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE01 RID: 56833 RVA: 0x0024EFF0 File Offset: 0x0024D1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gKAPDOCPCJM_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GKAPDOCPCJM);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE02 RID: 56834 RVA: 0x0024F04C File Offset: 0x0024D24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.gKAPDOCPCJM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GKAPDOCPCJM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE03 RID: 56835 RVA: 0x0024F0A4 File Offset: 0x0024D2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureApplyPasterListScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.gKAPDOCPCJM_ != null)
			{
				if (this.gKAPDOCPCJM_ == null)
				{
					this.GKAPDOCPCJM = new KHKLKHNGDOG();
				}
				this.GKAPDOCPCJM.MergeFrom(other.GKAPDOCPCJM);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE04 RID: 56836 RVA: 0x0024F10C File Offset: 0x0024D30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE05 RID: 56837 RVA: 0x0024F118 File Offset: 0x0024D318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 40U)
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
					if (this.gKAPDOCPCJM_ == null)
					{
						this.GKAPDOCPCJM = new KHKLKHNGDOG();
					}
					input.ReadMessage(this.GKAPDOCPCJM);
				}
			}
		}

		// Token: 0x0400584C RID: 22604
		private static readonly MessageParser<TravelBrochureApplyPasterListScRsp> _parser = new MessageParser<TravelBrochureApplyPasterListScRsp>(() => new TravelBrochureApplyPasterListScRsp());

		// Token: 0x0400584D RID: 22605
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400584E RID: 22606
		public const int RetcodeFieldNumber = 5;

		// Token: 0x0400584F RID: 22607
		private uint retcode_;

		// Token: 0x04005850 RID: 22608
		public const int GKAPDOCPCJMFieldNumber = 4;

		// Token: 0x04005851 RID: 22609
		private KHKLKHNGDOG gKAPDOCPCJM_;
	}
}
