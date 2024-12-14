using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001321 RID: 4897
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueEndlessActivityAllBonusRewardCsReq : IMessage<TakeRogueEndlessActivityAllBonusRewardCsReq>, IMessage, IEquatable<TakeRogueEndlessActivityAllBonusRewardCsReq>, IDeepCloneable<TakeRogueEndlessActivityAllBonusRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x0600DA80 RID: 55936 RVA: 0x0024607C File Offset: 0x0024427C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueEndlessActivityAllBonusRewardCsReq> Parser
		{
			get
			{
				return TakeRogueEndlessActivityAllBonusRewardCsReq._parser;
			}
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x0600DA81 RID: 55937 RVA: 0x00246083 File Offset: 0x00244283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueEndlessActivityAllBonusRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x0600DA82 RID: 55938 RVA: 0x00246095 File Offset: 0x00244295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueEndlessActivityAllBonusRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DA83 RID: 55939 RVA: 0x0024609C File Offset: 0x0024429C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityAllBonusRewardCsReq()
		{
		}

		// Token: 0x0600DA84 RID: 55940 RVA: 0x002460A4 File Offset: 0x002442A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityAllBonusRewardCsReq(TakeRogueEndlessActivityAllBonusRewardCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA85 RID: 55941 RVA: 0x002460BD File Offset: 0x002442BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityAllBonusRewardCsReq Clone()
		{
			return new TakeRogueEndlessActivityAllBonusRewardCsReq(this);
		}

		// Token: 0x0600DA86 RID: 55942 RVA: 0x002460C5 File Offset: 0x002442C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueEndlessActivityAllBonusRewardCsReq);
		}

		// Token: 0x0600DA87 RID: 55943 RVA: 0x002460D3 File Offset: 0x002442D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueEndlessActivityAllBonusRewardCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600DA88 RID: 55944 RVA: 0x002460F4 File Offset: 0x002442F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA89 RID: 55945 RVA: 0x0024611A File Offset: 0x0024431A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DA8A RID: 55946 RVA: 0x00246122 File Offset: 0x00244322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA8B RID: 55947 RVA: 0x0024612B File Offset: 0x0024432B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA8C RID: 55948 RVA: 0x00246144 File Offset: 0x00244344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA8D RID: 55949 RVA: 0x0024616A File Offset: 0x0024436A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueEndlessActivityAllBonusRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA8E RID: 55950 RVA: 0x00246187 File Offset: 0x00244387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA8F RID: 55951 RVA: 0x00246190 File Offset: 0x00244390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005704 RID: 22276
		private static readonly MessageParser<TakeRogueEndlessActivityAllBonusRewardCsReq> _parser = new MessageParser<TakeRogueEndlessActivityAllBonusRewardCsReq>(() => new TakeRogueEndlessActivityAllBonusRewardCsReq());

		// Token: 0x04005705 RID: 22277
		private UnknownFieldSet _unknownFields;
	}
}
