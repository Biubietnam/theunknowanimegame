using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000763 RID: 1891
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlatformPlayerInfoScRsp : IMessage<GetPlatformPlayerInfoScRsp>, IMessage, IEquatable<GetPlatformPlayerInfoScRsp>, IDeepCloneable<GetPlatformPlayerInfoScRsp>, IBufferMessage
	{
		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x0600547F RID: 21631 RVA: 0x000E33A7 File Offset: 0x000E15A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlatformPlayerInfoScRsp> Parser
		{
			get
			{
				return GetPlatformPlayerInfoScRsp._parser;
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06005480 RID: 21632 RVA: 0x000E33AE File Offset: 0x000E15AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlatformPlayerInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06005481 RID: 21633 RVA: 0x000E33C0 File Offset: 0x000E15C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlatformPlayerInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x000E33C7 File Offset: 0x000E15C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlatformPlayerInfoScRsp()
		{
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x000E33DA File Offset: 0x000E15DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlatformPlayerInfoScRsp(GetPlatformPlayerInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.playerInfoList_ = other.playerInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x000E3410 File Offset: 0x000E1610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlatformPlayerInfoScRsp Clone()
		{
			return new GetPlatformPlayerInfoScRsp(this);
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06005485 RID: 21637 RVA: 0x000E3418 File Offset: 0x000E1618
		// (set) Token: 0x06005486 RID: 21638 RVA: 0x000E3420 File Offset: 0x000E1620
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

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06005487 RID: 21639 RVA: 0x000E3429 File Offset: 0x000E1629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSimpleInfo> PlayerInfoList
		{
			get
			{
				return this.playerInfoList_;
			}
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x000E3431 File Offset: 0x000E1631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlatformPlayerInfoScRsp);
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x000E3440 File Offset: 0x000E1640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlatformPlayerInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.playerInfoList_.Equals(other.playerInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x000E3490 File Offset: 0x000E1690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.playerInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x000E34DD File Offset: 0x000E16DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x000E34E5 File Offset: 0x000E16E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x000E34F0 File Offset: 0x000E16F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerInfoList_.WriteTo(ref output, GetPlatformPlayerInfoScRsp._repeated_playerInfoList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x000E3540 File Offset: 0x000E1740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.playerInfoList_.CalculateSize(GetPlatformPlayerInfoScRsp._repeated_playerInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x000E3594 File Offset: 0x000E1794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlatformPlayerInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.playerInfoList_.Add(other.playerInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x000E35E1 File Offset: 0x000E17E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x000E35EC File Offset: 0x000E17EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 88U)
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
					this.playerInfoList_.AddEntriesFrom(ref input, GetPlatformPlayerInfoScRsp._repeated_playerInfoList_codec);
				}
			}
		}

		// Token: 0x0400212D RID: 8493
		private static readonly MessageParser<GetPlatformPlayerInfoScRsp> _parser = new MessageParser<GetPlatformPlayerInfoScRsp>(() => new GetPlatformPlayerInfoScRsp());

		// Token: 0x0400212E RID: 8494
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400212F RID: 8495
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04002130 RID: 8496
		private uint retcode_;

		// Token: 0x04002131 RID: 8497
		public const int PlayerInfoListFieldNumber = 2;

		// Token: 0x04002132 RID: 8498
		private static readonly FieldCodec<PlayerSimpleInfo> _repeated_playerInfoList_codec = FieldCodec.ForMessage<PlayerSimpleInfo>(18U, PlayerSimpleInfo.Parser);

		// Token: 0x04002133 RID: 8499
		private readonly RepeatedField<PlayerSimpleInfo> playerInfoList_ = new RepeatedField<PlayerSimpleInfo>();
	}
}
