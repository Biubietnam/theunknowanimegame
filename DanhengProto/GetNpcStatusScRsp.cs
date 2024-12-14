using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200074F RID: 1871
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetNpcStatusScRsp : IMessage<GetNpcStatusScRsp>, IMessage, IEquatable<GetNpcStatusScRsp>, IDeepCloneable<GetNpcStatusScRsp>, IBufferMessage
	{
		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x060053A3 RID: 21411 RVA: 0x000E13CD File Offset: 0x000DF5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetNpcStatusScRsp> Parser
		{
			get
			{
				return GetNpcStatusScRsp._parser;
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x060053A4 RID: 21412 RVA: 0x000E13D4 File Offset: 0x000DF5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetNpcStatusScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x060053A5 RID: 21413 RVA: 0x000E13E6 File Offset: 0x000DF5E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetNpcStatusScRsp.Descriptor;
			}
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x000E13ED File Offset: 0x000DF5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcStatusScRsp()
		{
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x000E1400 File Offset: 0x000DF600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcStatusScRsp(GetNpcStatusScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.npcStatusList_ = other.npcStatusList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x000E1436 File Offset: 0x000DF636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcStatusScRsp Clone()
		{
			return new GetNpcStatusScRsp(this);
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x060053A9 RID: 21417 RVA: 0x000E143E File Offset: 0x000DF63E
		// (set) Token: 0x060053AA RID: 21418 RVA: 0x000E1446 File Offset: 0x000DF646
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

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x060053AB RID: 21419 RVA: 0x000E144F File Offset: 0x000DF64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NpcStatus> NpcStatusList
		{
			get
			{
				return this.npcStatusList_;
			}
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x000E1457 File Offset: 0x000DF657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetNpcStatusScRsp);
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x000E1468 File Offset: 0x000DF668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetNpcStatusScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.npcStatusList_.Equals(other.npcStatusList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x000E14B8 File Offset: 0x000DF6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.npcStatusList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x000E1505 File Offset: 0x000DF705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x000E150D File Offset: 0x000DF70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x000E1518 File Offset: 0x000DF718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			this.npcStatusList_.WriteTo(ref output, GetNpcStatusScRsp._repeated_npcStatusList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x000E1568 File Offset: 0x000DF768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.npcStatusList_.CalculateSize(GetNpcStatusScRsp._repeated_npcStatusList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x000E15BC File Offset: 0x000DF7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetNpcStatusScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.npcStatusList_.Add(other.npcStatusList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x000E1609 File Offset: 0x000DF809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x000E1614 File Offset: 0x000DF814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.npcStatusList_.AddEntriesFrom(ref input, GetNpcStatusScRsp._repeated_npcStatusList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040020E1 RID: 8417
		private static readonly MessageParser<GetNpcStatusScRsp> _parser = new MessageParser<GetNpcStatusScRsp>(() => new GetNpcStatusScRsp());

		// Token: 0x040020E2 RID: 8418
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020E3 RID: 8419
		public const int RetcodeFieldNumber = 8;

		// Token: 0x040020E4 RID: 8420
		private uint retcode_;

		// Token: 0x040020E5 RID: 8421
		public const int NpcStatusListFieldNumber = 12;

		// Token: 0x040020E6 RID: 8422
		private static readonly FieldCodec<NpcStatus> _repeated_npcStatusList_codec = FieldCodec.ForMessage<NpcStatus>(98U, NpcStatus.Parser);

		// Token: 0x040020E7 RID: 8423
		private readonly RepeatedField<NpcStatus> npcStatusList_ = new RepeatedField<NpcStatus>();
	}
}
