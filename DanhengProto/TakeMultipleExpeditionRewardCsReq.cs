using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012EF RID: 4847
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeMultipleExpeditionRewardCsReq : IMessage<TakeMultipleExpeditionRewardCsReq>, IMessage, IEquatable<TakeMultipleExpeditionRewardCsReq>, IDeepCloneable<TakeMultipleExpeditionRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x0600D845 RID: 55365 RVA: 0x00240B3D File Offset: 0x0023ED3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeMultipleExpeditionRewardCsReq> Parser
		{
			get
			{
				return TakeMultipleExpeditionRewardCsReq._parser;
			}
		}

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x0600D846 RID: 55366 RVA: 0x00240B44 File Offset: 0x0023ED44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeMultipleExpeditionRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x0600D847 RID: 55367 RVA: 0x00240B56 File Offset: 0x0023ED56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeMultipleExpeditionRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D848 RID: 55368 RVA: 0x00240B5D File Offset: 0x0023ED5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleExpeditionRewardCsReq()
		{
		}

		// Token: 0x0600D849 RID: 55369 RVA: 0x00240B70 File Offset: 0x0023ED70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleExpeditionRewardCsReq(TakeMultipleExpeditionRewardCsReq other) : this()
		{
			this.kOEHKPOIGFF_ = other.kOEHKPOIGFF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D84A RID: 55370 RVA: 0x00240B9A File Offset: 0x0023ED9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleExpeditionRewardCsReq Clone()
		{
			return new TakeMultipleExpeditionRewardCsReq(this);
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x0600D84B RID: 55371 RVA: 0x00240BA2 File Offset: 0x0023EDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KOEHKPOIGFF
		{
			get
			{
				return this.kOEHKPOIGFF_;
			}
		}

		// Token: 0x0600D84C RID: 55372 RVA: 0x00240BAA File Offset: 0x0023EDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeMultipleExpeditionRewardCsReq);
		}

		// Token: 0x0600D84D RID: 55373 RVA: 0x00240BB8 File Offset: 0x0023EDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeMultipleExpeditionRewardCsReq other)
		{
			return other != null && (other == this || (this.kOEHKPOIGFF_.Equals(other.kOEHKPOIGFF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D84E RID: 55374 RVA: 0x00240BEC File Offset: 0x0023EDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kOEHKPOIGFF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D84F RID: 55375 RVA: 0x00240C20 File Offset: 0x0023EE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D850 RID: 55376 RVA: 0x00240C28 File Offset: 0x0023EE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D851 RID: 55377 RVA: 0x00240C31 File Offset: 0x0023EE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kOEHKPOIGFF_.WriteTo(ref output, TakeMultipleExpeditionRewardCsReq._repeated_kOEHKPOIGFF_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D852 RID: 55378 RVA: 0x00240C58 File Offset: 0x0023EE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kOEHKPOIGFF_.CalculateSize(TakeMultipleExpeditionRewardCsReq._repeated_kOEHKPOIGFF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D853 RID: 55379 RVA: 0x00240C91 File Offset: 0x0023EE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeMultipleExpeditionRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.kOEHKPOIGFF_.Add(other.kOEHKPOIGFF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D854 RID: 55380 RVA: 0x00240CBF File Offset: 0x0023EEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D855 RID: 55381 RVA: 0x00240CC8 File Offset: 0x0023EEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.kOEHKPOIGFF_.AddEntriesFrom(ref input, TakeMultipleExpeditionRewardCsReq._repeated_kOEHKPOIGFF_codec);
				}
			}
		}

		// Token: 0x04005649 RID: 22089
		private static readonly MessageParser<TakeMultipleExpeditionRewardCsReq> _parser = new MessageParser<TakeMultipleExpeditionRewardCsReq>(() => new TakeMultipleExpeditionRewardCsReq());

		// Token: 0x0400564A RID: 22090
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400564B RID: 22091
		public const int KOEHKPOIGFFFieldNumber = 15;

		// Token: 0x0400564C RID: 22092
		private static readonly FieldCodec<uint> _repeated_kOEHKPOIGFF_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x0400564D RID: 22093
		private readonly RepeatedField<uint> kOEHKPOIGFF_ = new RepeatedField<uint>();
	}
}
