using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F2F RID: 3887
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicUnitReforgeCsReq : IMessage<RogueMagicUnitReforgeCsReq>, IMessage, IEquatable<RogueMagicUnitReforgeCsReq>, IDeepCloneable<RogueMagicUnitReforgeCsReq>, IBufferMessage
	{
		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x0600AD69 RID: 44393 RVA: 0x001D25F8 File Offset: 0x001D07F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicUnitReforgeCsReq> Parser
		{
			get
			{
				return RogueMagicUnitReforgeCsReq._parser;
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x0600AD6A RID: 44394 RVA: 0x001D25FF File Offset: 0x001D07FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitReforgeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x0600AD6B RID: 44395 RVA: 0x001D2611 File Offset: 0x001D0811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicUnitReforgeCsReq.Descriptor;
			}
		}

		// Token: 0x0600AD6C RID: 44396 RVA: 0x001D2618 File Offset: 0x001D0818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitReforgeCsReq()
		{
		}

		// Token: 0x0600AD6D RID: 44397 RVA: 0x001D262B File Offset: 0x001D082B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitReforgeCsReq(RogueMagicUnitReforgeCsReq other) : this()
		{
			this.magicUnitIdList_ = other.magicUnitIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD6E RID: 44398 RVA: 0x001D2655 File Offset: 0x001D0855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitReforgeCsReq Clone()
		{
			return new RogueMagicUnitReforgeCsReq(this);
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x0600AD6F RID: 44399 RVA: 0x001D265D File Offset: 0x001D085D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MagicUnitIdList
		{
			get
			{
				return this.magicUnitIdList_;
			}
		}

		// Token: 0x0600AD70 RID: 44400 RVA: 0x001D2665 File Offset: 0x001D0865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicUnitReforgeCsReq);
		}

		// Token: 0x0600AD71 RID: 44401 RVA: 0x001D2673 File Offset: 0x001D0873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicUnitReforgeCsReq other)
		{
			return other != null && (other == this || (this.magicUnitIdList_.Equals(other.magicUnitIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD72 RID: 44402 RVA: 0x001D26A8 File Offset: 0x001D08A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.magicUnitIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD73 RID: 44403 RVA: 0x001D26DC File Offset: 0x001D08DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD74 RID: 44404 RVA: 0x001D26E4 File Offset: 0x001D08E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD75 RID: 44405 RVA: 0x001D26ED File Offset: 0x001D08ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.magicUnitIdList_.WriteTo(ref output, RogueMagicUnitReforgeCsReq._repeated_magicUnitIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD76 RID: 44406 RVA: 0x001D2714 File Offset: 0x001D0914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.magicUnitIdList_.CalculateSize(RogueMagicUnitReforgeCsReq._repeated_magicUnitIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD77 RID: 44407 RVA: 0x001D274D File Offset: 0x001D094D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicUnitReforgeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.magicUnitIdList_.Add(other.magicUnitIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD78 RID: 44408 RVA: 0x001D277B File Offset: 0x001D097B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD79 RID: 44409 RVA: 0x001D2784 File Offset: 0x001D0984
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
					this.magicUnitIdList_.AddEntriesFrom(ref input, RogueMagicUnitReforgeCsReq._repeated_magicUnitIdList_codec);
				}
			}
		}

		// Token: 0x0400469B RID: 18075
		private static readonly MessageParser<RogueMagicUnitReforgeCsReq> _parser = new MessageParser<RogueMagicUnitReforgeCsReq>(() => new RogueMagicUnitReforgeCsReq());

		// Token: 0x0400469C RID: 18076
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400469D RID: 18077
		public const int MagicUnitIdListFieldNumber = 4;

		// Token: 0x0400469E RID: 18078
		private static readonly FieldCodec<uint> _repeated_magicUnitIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x0400469F RID: 18079
		private readonly RepeatedField<uint> magicUnitIdList_ = new RepeatedField<uint>();
	}
}
