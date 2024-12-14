using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CE3 RID: 3299
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnTakeRewardScRsp : IMessage<PlayerReturnTakeRewardScRsp>, IMessage, IEquatable<PlayerReturnTakeRewardScRsp>, IDeepCloneable<PlayerReturnTakeRewardScRsp>, IBufferMessage
	{
		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x0600932A RID: 37674 RVA: 0x001862A8 File Offset: 0x001844A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnTakeRewardScRsp> Parser
		{
			get
			{
				return PlayerReturnTakeRewardScRsp._parser;
			}
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x0600932B RID: 37675 RVA: 0x001862AF File Offset: 0x001844AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnTakeRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x0600932C RID: 37676 RVA: 0x001862C1 File Offset: 0x001844C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnTakeRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600932D RID: 37677 RVA: 0x001862C8 File Offset: 0x001844C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakeRewardScRsp()
		{
		}

		// Token: 0x0600932E RID: 37678 RVA: 0x001862D0 File Offset: 0x001844D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakeRewardScRsp(PlayerReturnTakeRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600932F RID: 37679 RVA: 0x001862F5 File Offset: 0x001844F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakeRewardScRsp Clone()
		{
			return new PlayerReturnTakeRewardScRsp(this);
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x06009330 RID: 37680 RVA: 0x001862FD File Offset: 0x001844FD
		// (set) Token: 0x06009331 RID: 37681 RVA: 0x00186305 File Offset: 0x00184505
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

		// Token: 0x06009332 RID: 37682 RVA: 0x0018630E File Offset: 0x0018450E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnTakeRewardScRsp);
		}

		// Token: 0x06009333 RID: 37683 RVA: 0x0018631C File Offset: 0x0018451C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnTakeRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009334 RID: 37684 RVA: 0x0018634C File Offset: 0x0018454C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06009335 RID: 37685 RVA: 0x0018638B File Offset: 0x0018458B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x00186393 File Offset: 0x00184593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x0018639C File Offset: 0x0018459C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009338 RID: 37688 RVA: 0x001863D0 File Offset: 0x001845D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06009339 RID: 37689 RVA: 0x0018640E File Offset: 0x0018460E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnTakeRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600933A RID: 37690 RVA: 0x0018643F File Offset: 0x0018463F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600933B RID: 37691 RVA: 0x00186448 File Offset: 0x00184648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040038C0 RID: 14528
		private static readonly MessageParser<PlayerReturnTakeRewardScRsp> _parser = new MessageParser<PlayerReturnTakeRewardScRsp>(() => new PlayerReturnTakeRewardScRsp());

		// Token: 0x040038C1 RID: 14529
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038C2 RID: 14530
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040038C3 RID: 14531
		private uint retcode_;
	}
}
