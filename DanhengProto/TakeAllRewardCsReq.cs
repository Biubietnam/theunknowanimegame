using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012B3 RID: 4787
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeAllRewardCsReq : IMessage<TakeAllRewardCsReq>, IMessage, IEquatable<TakeAllRewardCsReq>, IDeepCloneable<TakeAllRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x0600D588 RID: 54664 RVA: 0x00239E39 File Offset: 0x00238039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeAllRewardCsReq> Parser
		{
			get
			{
				return TakeAllRewardCsReq._parser;
			}
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x0600D589 RID: 54665 RVA: 0x00239E40 File Offset: 0x00238040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeAllRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x0600D58A RID: 54666 RVA: 0x00239E52 File Offset: 0x00238052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeAllRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x00239E59 File Offset: 0x00238059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllRewardCsReq()
		{
		}

		// Token: 0x0600D58C RID: 54668 RVA: 0x00239E6C File Offset: 0x0023806C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllRewardCsReq(TakeAllRewardCsReq other) : this()
		{
			this.cNFKICIKGJM_ = other.cNFKICIKGJM_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D58D RID: 54669 RVA: 0x00239E96 File Offset: 0x00238096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllRewardCsReq Clone()
		{
			return new TakeAllRewardCsReq(this);
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x0600D58E RID: 54670 RVA: 0x00239E9E File Offset: 0x0023809E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OptionalReward> CNFKICIKGJM
		{
			get
			{
				return this.cNFKICIKGJM_;
			}
		}

		// Token: 0x0600D58F RID: 54671 RVA: 0x00239EA6 File Offset: 0x002380A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeAllRewardCsReq);
		}

		// Token: 0x0600D590 RID: 54672 RVA: 0x00239EB4 File Offset: 0x002380B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeAllRewardCsReq other)
		{
			return other != null && (other == this || (this.cNFKICIKGJM_.Equals(other.cNFKICIKGJM_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D591 RID: 54673 RVA: 0x00239EE8 File Offset: 0x002380E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cNFKICIKGJM_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D592 RID: 54674 RVA: 0x00239F1C File Offset: 0x0023811C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D593 RID: 54675 RVA: 0x00239F24 File Offset: 0x00238124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D594 RID: 54676 RVA: 0x00239F2D File Offset: 0x0023812D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cNFKICIKGJM_.WriteTo(ref output, TakeAllRewardCsReq._repeated_cNFKICIKGJM_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D595 RID: 54677 RVA: 0x00239F54 File Offset: 0x00238154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cNFKICIKGJM_.CalculateSize(TakeAllRewardCsReq._repeated_cNFKICIKGJM_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D596 RID: 54678 RVA: 0x00239F8D File Offset: 0x0023818D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeAllRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.cNFKICIKGJM_.Add(other.cNFKICIKGJM_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D597 RID: 54679 RVA: 0x00239FBB File Offset: 0x002381BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D598 RID: 54680 RVA: 0x00239FC4 File Offset: 0x002381C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cNFKICIKGJM_.AddEntriesFrom(ref input, TakeAllRewardCsReq._repeated_cNFKICIKGJM_codec);
				}
			}
		}

		// Token: 0x0400555A RID: 21850
		private static readonly MessageParser<TakeAllRewardCsReq> _parser = new MessageParser<TakeAllRewardCsReq>(() => new TakeAllRewardCsReq());

		// Token: 0x0400555B RID: 21851
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400555C RID: 21852
		public const int CNFKICIKGJMFieldNumber = 9;

		// Token: 0x0400555D RID: 21853
		private static readonly FieldCodec<OptionalReward> _repeated_cNFKICIKGJM_codec = FieldCodec.ForMessage<OptionalReward>(74U, OptionalReward.Parser);

		// Token: 0x0400555E RID: 21854
		private readonly RepeatedField<OptionalReward> cNFKICIKGJM_ = new RepeatedField<OptionalReward>();
	}
}
