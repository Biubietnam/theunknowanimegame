using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F29 RID: 3881
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicUnitComposeCsReq : IMessage<RogueMagicUnitComposeCsReq>, IMessage, IEquatable<RogueMagicUnitComposeCsReq>, IDeepCloneable<RogueMagicUnitComposeCsReq>, IBufferMessage
	{
		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x0600AD29 RID: 44329 RVA: 0x001D1DE0 File Offset: 0x001CFFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicUnitComposeCsReq> Parser
		{
			get
			{
				return RogueMagicUnitComposeCsReq._parser;
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x0600AD2A RID: 44330 RVA: 0x001D1DE7 File Offset: 0x001CFFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitComposeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x0600AD2B RID: 44331 RVA: 0x001D1DF9 File Offset: 0x001CFFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicUnitComposeCsReq.Descriptor;
			}
		}

		// Token: 0x0600AD2C RID: 44332 RVA: 0x001D1E00 File Offset: 0x001D0000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitComposeCsReq()
		{
		}

		// Token: 0x0600AD2D RID: 44333 RVA: 0x001D1E13 File Offset: 0x001D0013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitComposeCsReq(RogueMagicUnitComposeCsReq other) : this()
		{
			this.magicUnitIdList_ = other.magicUnitIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD2E RID: 44334 RVA: 0x001D1E3D File Offset: 0x001D003D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitComposeCsReq Clone()
		{
			return new RogueMagicUnitComposeCsReq(this);
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x0600AD2F RID: 44335 RVA: 0x001D1E45 File Offset: 0x001D0045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MagicUnitIdList
		{
			get
			{
				return this.magicUnitIdList_;
			}
		}

		// Token: 0x0600AD30 RID: 44336 RVA: 0x001D1E4D File Offset: 0x001D004D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicUnitComposeCsReq);
		}

		// Token: 0x0600AD31 RID: 44337 RVA: 0x001D1E5B File Offset: 0x001D005B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicUnitComposeCsReq other)
		{
			return other != null && (other == this || (this.magicUnitIdList_.Equals(other.magicUnitIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD32 RID: 44338 RVA: 0x001D1E90 File Offset: 0x001D0090
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

		// Token: 0x0600AD33 RID: 44339 RVA: 0x001D1EC4 File Offset: 0x001D00C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD34 RID: 44340 RVA: 0x001D1ECC File Offset: 0x001D00CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x001D1ED5 File Offset: 0x001D00D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.magicUnitIdList_.WriteTo(ref output, RogueMagicUnitComposeCsReq._repeated_magicUnitIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD36 RID: 44342 RVA: 0x001D1EFC File Offset: 0x001D00FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.magicUnitIdList_.CalculateSize(RogueMagicUnitComposeCsReq._repeated_magicUnitIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD37 RID: 44343 RVA: 0x001D1F35 File Offset: 0x001D0135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicUnitComposeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.magicUnitIdList_.Add(other.magicUnitIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD38 RID: 44344 RVA: 0x001D1F63 File Offset: 0x001D0163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD39 RID: 44345 RVA: 0x001D1F6C File Offset: 0x001D016C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.magicUnitIdList_.AddEntriesFrom(ref input, RogueMagicUnitComposeCsReq._repeated_magicUnitIdList_codec);
				}
			}
		}

		// Token: 0x04004689 RID: 18057
		private static readonly MessageParser<RogueMagicUnitComposeCsReq> _parser = new MessageParser<RogueMagicUnitComposeCsReq>(() => new RogueMagicUnitComposeCsReq());

		// Token: 0x0400468A RID: 18058
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400468B RID: 18059
		public const int MagicUnitIdListFieldNumber = 6;

		// Token: 0x0400468C RID: 18060
		private static readonly FieldCodec<uint> _repeated_magicUnitIdList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x0400468D RID: 18061
		private readonly RepeatedField<uint> magicUnitIdList_ = new RepeatedField<uint>();
	}
}
