using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200114F RID: 4431
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShowNewSupplementVisitorCsReq : IMessage<ShowNewSupplementVisitorCsReq>, IMessage, IEquatable<ShowNewSupplementVisitorCsReq>, IDeepCloneable<ShowNewSupplementVisitorCsReq>, IBufferMessage
	{
		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600C5B4 RID: 50612 RVA: 0x00212A4C File Offset: 0x00210C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShowNewSupplementVisitorCsReq> Parser
		{
			get
			{
				return ShowNewSupplementVisitorCsReq._parser;
			}
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600C5B5 RID: 50613 RVA: 0x00212A53 File Offset: 0x00210C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ShowNewSupplementVisitorCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600C5B6 RID: 50614 RVA: 0x00212A65 File Offset: 0x00210C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowNewSupplementVisitorCsReq.Descriptor;
			}
		}

		// Token: 0x0600C5B7 RID: 50615 RVA: 0x00212A6C File Offset: 0x00210C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowNewSupplementVisitorCsReq()
		{
		}

		// Token: 0x0600C5B8 RID: 50616 RVA: 0x00212A7F File Offset: 0x00210C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowNewSupplementVisitorCsReq(ShowNewSupplementVisitorCsReq other) : this()
		{
			this.bHJEIMILLPF_ = other.bHJEIMILLPF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5B9 RID: 50617 RVA: 0x00212AA9 File Offset: 0x00210CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowNewSupplementVisitorCsReq Clone()
		{
			return new ShowNewSupplementVisitorCsReq(this);
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600C5BA RID: 50618 RVA: 0x00212AB1 File Offset: 0x00210CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BHJEIMILLPF
		{
			get
			{
				return this.bHJEIMILLPF_;
			}
		}

		// Token: 0x0600C5BB RID: 50619 RVA: 0x00212AB9 File Offset: 0x00210CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowNewSupplementVisitorCsReq);
		}

		// Token: 0x0600C5BC RID: 50620 RVA: 0x00212AC7 File Offset: 0x00210CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowNewSupplementVisitorCsReq other)
		{
			return other != null && (other == this || (this.bHJEIMILLPF_.Equals(other.bHJEIMILLPF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5BD RID: 50621 RVA: 0x00212AFC File Offset: 0x00210CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bHJEIMILLPF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C5BE RID: 50622 RVA: 0x00212B30 File Offset: 0x00210D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C5BF RID: 50623 RVA: 0x00212B38 File Offset: 0x00210D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5C0 RID: 50624 RVA: 0x00212B41 File Offset: 0x00210D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bHJEIMILLPF_.WriteTo(ref output, ShowNewSupplementVisitorCsReq._repeated_bHJEIMILLPF_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5C1 RID: 50625 RVA: 0x00212B68 File Offset: 0x00210D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bHJEIMILLPF_.CalculateSize(ShowNewSupplementVisitorCsReq._repeated_bHJEIMILLPF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C5C2 RID: 50626 RVA: 0x00212BA1 File Offset: 0x00210DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShowNewSupplementVisitorCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.bHJEIMILLPF_.Add(other.bHJEIMILLPF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C5C3 RID: 50627 RVA: 0x00212BCF File Offset: 0x00210DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5C4 RID: 50628 RVA: 0x00212BD8 File Offset: 0x00210DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bHJEIMILLPF_.AddEntriesFrom(ref input, ShowNewSupplementVisitorCsReq._repeated_bHJEIMILLPF_codec);
				}
			}
		}

		// Token: 0x04004FD9 RID: 20441
		private static readonly MessageParser<ShowNewSupplementVisitorCsReq> _parser = new MessageParser<ShowNewSupplementVisitorCsReq>(() => new ShowNewSupplementVisitorCsReq());

		// Token: 0x04004FDA RID: 20442
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FDB RID: 20443
		public const int BHJEIMILLPFFieldNumber = 4;

		// Token: 0x04004FDC RID: 20444
		private static readonly FieldCodec<uint> _repeated_bHJEIMILLPF_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04004FDD RID: 20445
		private readonly RepeatedField<uint> bHJEIMILLPF_ = new RepeatedField<uint>();
	}
}
