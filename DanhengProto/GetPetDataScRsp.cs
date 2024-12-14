using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200075B RID: 1883
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPetDataScRsp : IMessage<GetPetDataScRsp>, IMessage, IEquatable<GetPetDataScRsp>, IDeepCloneable<GetPetDataScRsp>, IBufferMessage
	{
		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06005423 RID: 21539 RVA: 0x000E2509 File Offset: 0x000E0709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPetDataScRsp> Parser
		{
			get
			{
				return GetPetDataScRsp._parser;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x000E2510 File Offset: 0x000E0710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPetDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06005425 RID: 21541 RVA: 0x000E2522 File Offset: 0x000E0722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPetDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x000E2529 File Offset: 0x000E0729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPetDataScRsp()
		{
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x000E253C File Offset: 0x000E073C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPetDataScRsp(GetPetDataScRsp other) : this()
		{
			this.petIdList_ = other.petIdList_.Clone();
			this.retcode_ = other.retcode_;
			this.curPetId_ = other.curPetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x000E2589 File Offset: 0x000E0789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPetDataScRsp Clone()
		{
			return new GetPetDataScRsp(this);
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06005429 RID: 21545 RVA: 0x000E2591 File Offset: 0x000E0791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PetIdList
		{
			get
			{
				return this.petIdList_;
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x0600542A RID: 21546 RVA: 0x000E2599 File Offset: 0x000E0799
		// (set) Token: 0x0600542B RID: 21547 RVA: 0x000E25A1 File Offset: 0x000E07A1
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

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x000E25AA File Offset: 0x000E07AA
		// (set) Token: 0x0600542D RID: 21549 RVA: 0x000E25B2 File Offset: 0x000E07B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurPetId
		{
			get
			{
				return this.curPetId_;
			}
			set
			{
				this.curPetId_ = value;
			}
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x000E25BB File Offset: 0x000E07BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPetDataScRsp);
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x000E25CC File Offset: 0x000E07CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPetDataScRsp other)
		{
			return other != null && (other == this || (this.petIdList_.Equals(other.petIdList_) && this.Retcode == other.Retcode && this.CurPetId == other.CurPetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x000E262C File Offset: 0x000E082C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.petIdList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurPetId != 0U)
			{
				num ^= this.CurPetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x000E2692 File Offset: 0x000E0892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x000E269A File Offset: 0x000E089A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x000E26A4 File Offset: 0x000E08A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.petIdList_.WriteTo(ref output, GetPetDataScRsp._repeated_petIdList_codec);
			if (this.CurPetId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CurPetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x000E2710 File Offset: 0x000E0910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.petIdList_.CalculateSize(GetPetDataScRsp._repeated_petIdList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurPetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurPetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x000E277C File Offset: 0x000E097C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPetDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.petIdList_.Add(other.petIdList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurPetId != 0U)
			{
				this.CurPetId = other.CurPetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x000E27DD File Offset: 0x000E09DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x000E27E8 File Offset: 0x000E09E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						goto IL_3F;
					}
				}
				else
				{
					if (num == 50U)
					{
						goto IL_3F;
					}
					if (num == 80U)
					{
						this.CurPetId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3F:
				this.petIdList_.AddEntriesFrom(ref input, GetPetDataScRsp._repeated_petIdList_codec);
			}
		}

		// Token: 0x04002109 RID: 8457
		private static readonly MessageParser<GetPetDataScRsp> _parser = new MessageParser<GetPetDataScRsp>(() => new GetPetDataScRsp());

		// Token: 0x0400210A RID: 8458
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400210B RID: 8459
		public const int PetIdListFieldNumber = 6;

		// Token: 0x0400210C RID: 8460
		private static readonly FieldCodec<uint> _repeated_petIdList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x0400210D RID: 8461
		private readonly RepeatedField<uint> petIdList_ = new RepeatedField<uint>();

		// Token: 0x0400210E RID: 8462
		public const int RetcodeFieldNumber = 4;

		// Token: 0x0400210F RID: 8463
		private uint retcode_;

		// Token: 0x04002110 RID: 8464
		public const int CurPetIdFieldNumber = 10;

		// Token: 0x04002111 RID: 8465
		private uint curPetId_;
	}
}
