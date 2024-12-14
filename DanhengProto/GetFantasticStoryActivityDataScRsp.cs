using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000697 RID: 1687
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFantasticStoryActivityDataScRsp : IMessage<GetFantasticStoryActivityDataScRsp>, IMessage, IEquatable<GetFantasticStoryActivityDataScRsp>, IDeepCloneable<GetFantasticStoryActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06004B8D RID: 19341 RVA: 0x000CD4F7 File Offset: 0x000CB6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFantasticStoryActivityDataScRsp> Parser
		{
			get
			{
				return GetFantasticStoryActivityDataScRsp._parser;
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06004B8E RID: 19342 RVA: 0x000CD4FE File Offset: 0x000CB6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFantasticStoryActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06004B8F RID: 19343 RVA: 0x000CD510 File Offset: 0x000CB710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFantasticStoryActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x000CD517 File Offset: 0x000CB717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFantasticStoryActivityDataScRsp()
		{
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x000CD520 File Offset: 0x000CB720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFantasticStoryActivityDataScRsp(GetFantasticStoryActivityDataScRsp other) : this()
		{
			this.lHGEBDIFNAP_ = ((other.lHGEBDIFNAP_ != null) ? other.lHGEBDIFNAP_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x000CD56C File Offset: 0x000CB76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFantasticStoryActivityDataScRsp Clone()
		{
			return new GetFantasticStoryActivityDataScRsp(this);
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x000CD574 File Offset: 0x000CB774
		// (set) Token: 0x06004B94 RID: 19348 RVA: 0x000CD57C File Offset: 0x000CB77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FantasticActivityData LHGEBDIFNAP
		{
			get
			{
				return this.lHGEBDIFNAP_;
			}
			set
			{
				this.lHGEBDIFNAP_ = value;
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06004B95 RID: 19349 RVA: 0x000CD585 File Offset: 0x000CB785
		// (set) Token: 0x06004B96 RID: 19350 RVA: 0x000CD58D File Offset: 0x000CB78D
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

		// Token: 0x06004B97 RID: 19351 RVA: 0x000CD596 File Offset: 0x000CB796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFantasticStoryActivityDataScRsp);
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x000CD5A4 File Offset: 0x000CB7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFantasticStoryActivityDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.LHGEBDIFNAP, other.LHGEBDIFNAP) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x000CD5F4 File Offset: 0x000CB7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lHGEBDIFNAP_ != null)
			{
				num ^= this.LHGEBDIFNAP.GetHashCode();
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

		// Token: 0x06004B9A RID: 19354 RVA: 0x000CD649 File Offset: 0x000CB849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x000CD651 File Offset: 0x000CB851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x000CD65C File Offset: 0x000CB85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lHGEBDIFNAP_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.LHGEBDIFNAP);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x000CD6B8 File Offset: 0x000CB8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lHGEBDIFNAP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LHGEBDIFNAP);
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

		// Token: 0x06004B9E RID: 19358 RVA: 0x000CD710 File Offset: 0x000CB910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFantasticStoryActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lHGEBDIFNAP_ != null)
			{
				if (this.lHGEBDIFNAP_ == null)
				{
					this.LHGEBDIFNAP = new FantasticActivityData();
				}
				this.LHGEBDIFNAP.MergeFrom(other.LHGEBDIFNAP);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x000CD778 File Offset: 0x000CB978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x000CD784 File Offset: 0x000CB984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 96U)
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
					if (this.lHGEBDIFNAP_ == null)
					{
						this.LHGEBDIFNAP = new FantasticActivityData();
					}
					input.ReadMessage(this.LHGEBDIFNAP);
				}
			}
		}

		// Token: 0x04001DF3 RID: 7667
		private static readonly MessageParser<GetFantasticStoryActivityDataScRsp> _parser = new MessageParser<GetFantasticStoryActivityDataScRsp>(() => new GetFantasticStoryActivityDataScRsp());

		// Token: 0x04001DF4 RID: 7668
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DF5 RID: 7669
		public const int LHGEBDIFNAPFieldNumber = 7;

		// Token: 0x04001DF6 RID: 7670
		private FantasticActivityData lHGEBDIFNAP_;

		// Token: 0x04001DF7 RID: 7671
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04001DF8 RID: 7672
		private uint retcode_;
	}
}
