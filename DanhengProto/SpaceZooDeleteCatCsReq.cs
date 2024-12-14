using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001163 RID: 4451
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooDeleteCatCsReq : IMessage<SpaceZooDeleteCatCsReq>, IMessage, IEquatable<SpaceZooDeleteCatCsReq>, IDeepCloneable<SpaceZooDeleteCatCsReq>, IBufferMessage
	{
		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x0600C698 RID: 50840 RVA: 0x00215380 File Offset: 0x00213580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooDeleteCatCsReq> Parser
		{
			get
			{
				return SpaceZooDeleteCatCsReq._parser;
			}
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x0600C699 RID: 50841 RVA: 0x00215387 File Offset: 0x00213587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooDeleteCatCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x0600C69A RID: 50842 RVA: 0x00215399 File Offset: 0x00213599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooDeleteCatCsReq.Descriptor;
			}
		}

		// Token: 0x0600C69B RID: 50843 RVA: 0x002153A0 File Offset: 0x002135A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDeleteCatCsReq()
		{
		}

		// Token: 0x0600C69C RID: 50844 RVA: 0x002153B3 File Offset: 0x002135B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDeleteCatCsReq(SpaceZooDeleteCatCsReq other) : this()
		{
			this.hBHLEFBHFHI_ = other.hBHLEFBHFHI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C69D RID: 50845 RVA: 0x002153DD File Offset: 0x002135DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDeleteCatCsReq Clone()
		{
			return new SpaceZooDeleteCatCsReq(this);
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0600C69E RID: 50846 RVA: 0x002153E5 File Offset: 0x002135E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HBHLEFBHFHI
		{
			get
			{
				return this.hBHLEFBHFHI_;
			}
		}

		// Token: 0x0600C69F RID: 50847 RVA: 0x002153ED File Offset: 0x002135ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooDeleteCatCsReq);
		}

		// Token: 0x0600C6A0 RID: 50848 RVA: 0x002153FB File Offset: 0x002135FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooDeleteCatCsReq other)
		{
			return other != null && (other == this || (this.hBHLEFBHFHI_.Equals(other.hBHLEFBHFHI_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6A1 RID: 50849 RVA: 0x00215430 File Offset: 0x00213630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hBHLEFBHFHI_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C6A2 RID: 50850 RVA: 0x00215464 File Offset: 0x00213664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C6A3 RID: 50851 RVA: 0x0021546C File Offset: 0x0021366C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6A4 RID: 50852 RVA: 0x00215475 File Offset: 0x00213675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hBHLEFBHFHI_.WriteTo(ref output, SpaceZooDeleteCatCsReq._repeated_hBHLEFBHFHI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6A5 RID: 50853 RVA: 0x0021549C File Offset: 0x0021369C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hBHLEFBHFHI_.CalculateSize(SpaceZooDeleteCatCsReq._repeated_hBHLEFBHFHI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6A6 RID: 50854 RVA: 0x002154D5 File Offset: 0x002136D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooDeleteCatCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.hBHLEFBHFHI_.Add(other.hBHLEFBHFHI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C6A7 RID: 50855 RVA: 0x00215503 File Offset: 0x00213703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6A8 RID: 50856 RVA: 0x0021550C File Offset: 0x0021370C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hBHLEFBHFHI_.AddEntriesFrom(ref input, SpaceZooDeleteCatCsReq._repeated_hBHLEFBHFHI_codec);
				}
			}
		}

		// Token: 0x04005046 RID: 20550
		private static readonly MessageParser<SpaceZooDeleteCatCsReq> _parser = new MessageParser<SpaceZooDeleteCatCsReq>(() => new SpaceZooDeleteCatCsReq());

		// Token: 0x04005047 RID: 20551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005048 RID: 20552
		public const int HBHLEFBHFHIFieldNumber = 8;

		// Token: 0x04005049 RID: 20553
		private static readonly FieldCodec<uint> _repeated_hBHLEFBHFHI_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x0400504A RID: 20554
		private readonly RepeatedField<uint> hBHLEFBHFHI_ = new RepeatedField<uint>();
	}
}
