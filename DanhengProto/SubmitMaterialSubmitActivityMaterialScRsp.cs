using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011FD RID: 4605
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubmitMaterialSubmitActivityMaterialScRsp : IMessage<SubmitMaterialSubmitActivityMaterialScRsp>, IMessage, IEquatable<SubmitMaterialSubmitActivityMaterialScRsp>, IDeepCloneable<SubmitMaterialSubmitActivityMaterialScRsp>, IBufferMessage
	{
		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x0600CDD2 RID: 52690 RVA: 0x00228547 File Offset: 0x00226747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubmitMaterialSubmitActivityMaterialScRsp> Parser
		{
			get
			{
				return SubmitMaterialSubmitActivityMaterialScRsp._parser;
			}
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x0600CDD3 RID: 52691 RVA: 0x0022854E File Offset: 0x0022674E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SubmitMaterialSubmitActivityMaterialScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0600CDD4 RID: 52692 RVA: 0x00228560 File Offset: 0x00226760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitMaterialSubmitActivityMaterialScRsp.Descriptor;
			}
		}

		// Token: 0x0600CDD5 RID: 52693 RVA: 0x00228567 File Offset: 0x00226767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitMaterialSubmitActivityMaterialScRsp()
		{
		}

		// Token: 0x0600CDD6 RID: 52694 RVA: 0x00228570 File Offset: 0x00226770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitMaterialSubmitActivityMaterialScRsp(SubmitMaterialSubmitActivityMaterialScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.aIBKOCHDHDD_ = ((other.aIBKOCHDHDD_ != null) ? other.aIBKOCHDHDD_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDD7 RID: 52695 RVA: 0x002285BC File Offset: 0x002267BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitMaterialSubmitActivityMaterialScRsp Clone()
		{
			return new SubmitMaterialSubmitActivityMaterialScRsp(this);
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x0600CDD8 RID: 52696 RVA: 0x002285C4 File Offset: 0x002267C4
		// (set) Token: 0x0600CDD9 RID: 52697 RVA: 0x002285CC File Offset: 0x002267CC
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

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x0600CDDA RID: 52698 RVA: 0x002285D5 File Offset: 0x002267D5
		// (set) Token: 0x0600CDDB RID: 52699 RVA: 0x002285DD File Offset: 0x002267DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ONLKNGEBBIE AIBKOCHDHDD
		{
			get
			{
				return this.aIBKOCHDHDD_;
			}
			set
			{
				this.aIBKOCHDHDD_ = value;
			}
		}

		// Token: 0x0600CDDC RID: 52700 RVA: 0x002285E6 File Offset: 0x002267E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitMaterialSubmitActivityMaterialScRsp);
		}

		// Token: 0x0600CDDD RID: 52701 RVA: 0x002285F4 File Offset: 0x002267F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitMaterialSubmitActivityMaterialScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.AIBKOCHDHDD, other.AIBKOCHDHDD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDDE RID: 52702 RVA: 0x00228644 File Offset: 0x00226844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.aIBKOCHDHDD_ != null)
			{
				num ^= this.AIBKOCHDHDD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CDDF RID: 52703 RVA: 0x00228699 File Offset: 0x00226899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CDE0 RID: 52704 RVA: 0x002286A1 File Offset: 0x002268A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDE1 RID: 52705 RVA: 0x002286AC File Offset: 0x002268AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.aIBKOCHDHDD_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.AIBKOCHDHDD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDE2 RID: 52706 RVA: 0x00228708 File Offset: 0x00226908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.aIBKOCHDHDD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AIBKOCHDHDD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CDE3 RID: 52707 RVA: 0x00228760 File Offset: 0x00226960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitMaterialSubmitActivityMaterialScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.aIBKOCHDHDD_ != null)
			{
				if (this.aIBKOCHDHDD_ == null)
				{
					this.AIBKOCHDHDD = new ONLKNGEBBIE();
				}
				this.AIBKOCHDHDD.MergeFrom(other.AIBKOCHDHDD);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDE4 RID: 52708 RVA: 0x002287C8 File Offset: 0x002269C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDE5 RID: 52709 RVA: 0x002287D4 File Offset: 0x002269D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.aIBKOCHDHDD_ == null)
						{
							this.AIBKOCHDHDD = new ONLKNGEBBIE();
						}
						input.ReadMessage(this.AIBKOCHDHDD);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040052F8 RID: 21240
		private static readonly MessageParser<SubmitMaterialSubmitActivityMaterialScRsp> _parser = new MessageParser<SubmitMaterialSubmitActivityMaterialScRsp>(() => new SubmitMaterialSubmitActivityMaterialScRsp());

		// Token: 0x040052F9 RID: 21241
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052FA RID: 21242
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040052FB RID: 21243
		private uint retcode_;

		// Token: 0x040052FC RID: 21244
		public const int AIBKOCHDHDDFieldNumber = 12;

		// Token: 0x040052FD RID: 21245
		private ONLKNGEBBIE aIBKOCHDHDD_;
	}
}
