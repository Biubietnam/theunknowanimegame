using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012EB RID: 4843
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeMultipleActivityExpeditionRewardCsReq : IMessage<TakeMultipleActivityExpeditionRewardCsReq>, IMessage, IEquatable<TakeMultipleActivityExpeditionRewardCsReq>, IDeepCloneable<TakeMultipleActivityExpeditionRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x0600D81B RID: 55323 RVA: 0x0024055D File Offset: 0x0023E75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeMultipleActivityExpeditionRewardCsReq> Parser
		{
			get
			{
				return TakeMultipleActivityExpeditionRewardCsReq._parser;
			}
		}

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x0600D81C RID: 55324 RVA: 0x00240564 File Offset: 0x0023E764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeMultipleActivityExpeditionRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x0600D81D RID: 55325 RVA: 0x00240576 File Offset: 0x0023E776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeMultipleActivityExpeditionRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D81E RID: 55326 RVA: 0x0024057D File Offset: 0x0023E77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleActivityExpeditionRewardCsReq()
		{
		}

		// Token: 0x0600D81F RID: 55327 RVA: 0x00240590 File Offset: 0x0023E790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleActivityExpeditionRewardCsReq(TakeMultipleActivityExpeditionRewardCsReq other) : this()
		{
			this.hLOIKNKAPMN_ = other.hLOIKNKAPMN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D820 RID: 55328 RVA: 0x002405BA File Offset: 0x0023E7BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleActivityExpeditionRewardCsReq Clone()
		{
			return new TakeMultipleActivityExpeditionRewardCsReq(this);
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0600D821 RID: 55329 RVA: 0x002405C2 File Offset: 0x0023E7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HLOIKNKAPMN
		{
			get
			{
				return this.hLOIKNKAPMN_;
			}
		}

		// Token: 0x0600D822 RID: 55330 RVA: 0x002405CA File Offset: 0x0023E7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeMultipleActivityExpeditionRewardCsReq);
		}

		// Token: 0x0600D823 RID: 55331 RVA: 0x002405D8 File Offset: 0x0023E7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeMultipleActivityExpeditionRewardCsReq other)
		{
			return other != null && (other == this || (this.hLOIKNKAPMN_.Equals(other.hLOIKNKAPMN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D824 RID: 55332 RVA: 0x0024060C File Offset: 0x0023E80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hLOIKNKAPMN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D825 RID: 55333 RVA: 0x00240640 File Offset: 0x0023E840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D826 RID: 55334 RVA: 0x00240648 File Offset: 0x0023E848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D827 RID: 55335 RVA: 0x00240651 File Offset: 0x0023E851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hLOIKNKAPMN_.WriteTo(ref output, TakeMultipleActivityExpeditionRewardCsReq._repeated_hLOIKNKAPMN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D828 RID: 55336 RVA: 0x00240678 File Offset: 0x0023E878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hLOIKNKAPMN_.CalculateSize(TakeMultipleActivityExpeditionRewardCsReq._repeated_hLOIKNKAPMN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D829 RID: 55337 RVA: 0x002406B1 File Offset: 0x0023E8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeMultipleActivityExpeditionRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.hLOIKNKAPMN_.Add(other.hLOIKNKAPMN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D82A RID: 55338 RVA: 0x002406DF File Offset: 0x0023E8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D82B RID: 55339 RVA: 0x002406E8 File Offset: 0x0023E8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hLOIKNKAPMN_.AddEntriesFrom(ref input, TakeMultipleActivityExpeditionRewardCsReq._repeated_hLOIKNKAPMN_codec);
				}
			}
		}

		// Token: 0x0400563B RID: 22075
		private static readonly MessageParser<TakeMultipleActivityExpeditionRewardCsReq> _parser = new MessageParser<TakeMultipleActivityExpeditionRewardCsReq>(() => new TakeMultipleActivityExpeditionRewardCsReq());

		// Token: 0x0400563C RID: 22076
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400563D RID: 22077
		public const int HLOIKNKAPMNFieldNumber = 5;

		// Token: 0x0400563E RID: 22078
		private static readonly FieldCodec<uint> _repeated_hLOIKNKAPMN_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x0400563F RID: 22079
		private readonly RepeatedField<uint> hLOIKNKAPMN_ = new RepeatedField<uint>();
	}
}
