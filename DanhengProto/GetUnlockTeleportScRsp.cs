using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000843 RID: 2115
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetUnlockTeleportScRsp : IMessage<GetUnlockTeleportScRsp>, IMessage, IEquatable<GetUnlockTeleportScRsp>, IDeepCloneable<GetUnlockTeleportScRsp>, IBufferMessage
	{
		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06005E0F RID: 24079 RVA: 0x000F9309 File Offset: 0x000F7509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetUnlockTeleportScRsp> Parser
		{
			get
			{
				return GetUnlockTeleportScRsp._parser;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06005E10 RID: 24080 RVA: 0x000F9310 File Offset: 0x000F7510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetUnlockTeleportScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x000F9322 File Offset: 0x000F7522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetUnlockTeleportScRsp.Descriptor;
			}
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x000F9329 File Offset: 0x000F7529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUnlockTeleportScRsp()
		{
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x000F933C File Offset: 0x000F753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUnlockTeleportScRsp(GetUnlockTeleportScRsp other) : this()
		{
			this.unlockTeleportList_ = other.unlockTeleportList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x000F9372 File Offset: 0x000F7572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUnlockTeleportScRsp Clone()
		{
			return new GetUnlockTeleportScRsp(this);
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06005E15 RID: 24085 RVA: 0x000F937A File Offset: 0x000F757A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockTeleportList
		{
			get
			{
				return this.unlockTeleportList_;
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06005E16 RID: 24086 RVA: 0x000F9382 File Offset: 0x000F7582
		// (set) Token: 0x06005E17 RID: 24087 RVA: 0x000F938A File Offset: 0x000F758A
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

		// Token: 0x06005E18 RID: 24088 RVA: 0x000F9393 File Offset: 0x000F7593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetUnlockTeleportScRsp);
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x000F93A4 File Offset: 0x000F75A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetUnlockTeleportScRsp other)
		{
			return other != null && (other == this || (this.unlockTeleportList_.Equals(other.unlockTeleportList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x000F93F4 File Offset: 0x000F75F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockTeleportList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x000F9441 File Offset: 0x000F7641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x000F9449 File Offset: 0x000F7649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x000F9454 File Offset: 0x000F7654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockTeleportList_.WriteTo(ref output, GetUnlockTeleportScRsp._repeated_unlockTeleportList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x000F94A4 File Offset: 0x000F76A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockTeleportList_.CalculateSize(GetUnlockTeleportScRsp._repeated_unlockTeleportList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x000F94F8 File Offset: 0x000F76F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetUnlockTeleportScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockTeleportList_.Add(other.unlockTeleportList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x000F9545 File Offset: 0x000F7745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x000F9550 File Offset: 0x000F7750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U && num != 74U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.unlockTeleportList_.AddEntriesFrom(ref input, GetUnlockTeleportScRsp._repeated_unlockTeleportList_codec);
				}
			}
		}

		// Token: 0x04002442 RID: 9282
		private static readonly MessageParser<GetUnlockTeleportScRsp> _parser = new MessageParser<GetUnlockTeleportScRsp>(() => new GetUnlockTeleportScRsp());

		// Token: 0x04002443 RID: 9283
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002444 RID: 9284
		public const int UnlockTeleportListFieldNumber = 9;

		// Token: 0x04002445 RID: 9285
		private static readonly FieldCodec<uint> _repeated_unlockTeleportList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04002446 RID: 9286
		private readonly RepeatedField<uint> unlockTeleportList_ = new RepeatedField<uint>();

		// Token: 0x04002447 RID: 9287
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04002448 RID: 9288
		private uint retcode_;
	}
}
