using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013F7 RID: 5111
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateRotaterScNotify : IMessage<UpdateRotaterScNotify>, IMessage, IEquatable<UpdateRotaterScNotify>, IDeepCloneable<UpdateRotaterScNotify>, IBufferMessage
	{
		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x0600E3E5 RID: 58341 RVA: 0x0025E1AD File Offset: 0x0025C3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateRotaterScNotify> Parser
		{
			get
			{
				return UpdateRotaterScNotify._parser;
			}
		}

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x0600E3E6 RID: 58342 RVA: 0x0025E1B4 File Offset: 0x0025C3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateRotaterScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x0600E3E7 RID: 58343 RVA: 0x0025E1C6 File Offset: 0x0025C3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRotaterScNotify.Descriptor;
			}
		}

		// Token: 0x0600E3E8 RID: 58344 RVA: 0x0025E1CD File Offset: 0x0025C3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRotaterScNotify()
		{
		}

		// Token: 0x0600E3E9 RID: 58345 RVA: 0x0025E1E0 File Offset: 0x0025C3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRotaterScNotify(UpdateRotaterScNotify other) : this()
		{
			this.rotaterDataList_ = other.rotaterDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3EA RID: 58346 RVA: 0x0025E20A File Offset: 0x0025C40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRotaterScNotify Clone()
		{
			return new UpdateRotaterScNotify(this);
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x0600E3EB RID: 58347 RVA: 0x0025E212 File Offset: 0x0025C412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RotaterData> RotaterDataList
		{
			get
			{
				return this.rotaterDataList_;
			}
		}

		// Token: 0x0600E3EC RID: 58348 RVA: 0x0025E21A File Offset: 0x0025C41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRotaterScNotify);
		}

		// Token: 0x0600E3ED RID: 58349 RVA: 0x0025E228 File Offset: 0x0025C428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateRotaterScNotify other)
		{
			return other != null && (other == this || (this.rotaterDataList_.Equals(other.rotaterDataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3EE RID: 58350 RVA: 0x0025E25C File Offset: 0x0025C45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rotaterDataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E3EF RID: 58351 RVA: 0x0025E290 File Offset: 0x0025C490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E3F0 RID: 58352 RVA: 0x0025E298 File Offset: 0x0025C498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3F1 RID: 58353 RVA: 0x0025E2A1 File Offset: 0x0025C4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rotaterDataList_.WriteTo(ref output, UpdateRotaterScNotify._repeated_rotaterDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3F2 RID: 58354 RVA: 0x0025E2C8 File Offset: 0x0025C4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rotaterDataList_.CalculateSize(UpdateRotaterScNotify._repeated_rotaterDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3F3 RID: 58355 RVA: 0x0025E301 File Offset: 0x0025C501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateRotaterScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rotaterDataList_.Add(other.rotaterDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3F4 RID: 58356 RVA: 0x0025E32F File Offset: 0x0025C52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3F5 RID: 58357 RVA: 0x0025E338 File Offset: 0x0025C538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rotaterDataList_.AddEntriesFrom(ref input, UpdateRotaterScNotify._repeated_rotaterDataList_codec);
				}
			}
		}

		// Token: 0x04005A91 RID: 23185
		private static readonly MessageParser<UpdateRotaterScNotify> _parser = new MessageParser<UpdateRotaterScNotify>(() => new UpdateRotaterScNotify());

		// Token: 0x04005A92 RID: 23186
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A93 RID: 23187
		public const int RotaterDataListFieldNumber = 7;

		// Token: 0x04005A94 RID: 23188
		private static readonly FieldCodec<RotaterData> _repeated_rotaterDataList_codec = FieldCodec.ForMessage<RotaterData>(58U, RotaterData.Parser);

		// Token: 0x04005A95 RID: 23189
		private readonly RepeatedField<RotaterData> rotaterDataList_ = new RepeatedField<RotaterData>();
	}
}
