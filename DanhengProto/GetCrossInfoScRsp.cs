using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000669 RID: 1641
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCrossInfoScRsp : IMessage<GetCrossInfoScRsp>, IMessage, IEquatable<GetCrossInfoScRsp>, IDeepCloneable<GetCrossInfoScRsp>, IBufferMessage
	{
		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06004988 RID: 18824 RVA: 0x000C881B File Offset: 0x000C6A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCrossInfoScRsp> Parser
		{
			get
			{
				return GetCrossInfoScRsp._parser;
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x000C8822 File Offset: 0x000C6A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCrossInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x000C8834 File Offset: 0x000C6A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCrossInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x000C883B File Offset: 0x000C6A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCrossInfoScRsp()
		{
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x000C8844 File Offset: 0x000C6A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCrossInfoScRsp(GetCrossInfoScRsp other) : this()
		{
			this.roomId_ = other.roomId_;
			this.mGAIAJAKPEI_ = other.mGAIAJAKPEI_;
			this.retcode_ = other.retcode_;
			this.gCIGJDIMNCE_ = other.gCIGJDIMNCE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x000C8898 File Offset: 0x000C6A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCrossInfoScRsp Clone()
		{
			return new GetCrossInfoScRsp(this);
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x0600498E RID: 18830 RVA: 0x000C88A0 File Offset: 0x000C6AA0
		// (set) Token: 0x0600498F RID: 18831 RVA: 0x000C88A8 File Offset: 0x000C6AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x000C88B1 File Offset: 0x000C6AB1
		// (set) Token: 0x06004991 RID: 18833 RVA: 0x000C88B9 File Offset: 0x000C6AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightGameMode MGAIAJAKPEI
		{
			get
			{
				return this.mGAIAJAKPEI_;
			}
			set
			{
				this.mGAIAJAKPEI_ = value;
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x000C88C2 File Offset: 0x000C6AC2
		// (set) Token: 0x06004993 RID: 18835 RVA: 0x000C88CA File Offset: 0x000C6ACA
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

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06004994 RID: 18836 RVA: 0x000C88D3 File Offset: 0x000C6AD3
		// (set) Token: 0x06004995 RID: 18837 RVA: 0x000C88DB File Offset: 0x000C6ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong GCIGJDIMNCE
		{
			get
			{
				return this.gCIGJDIMNCE_;
			}
			set
			{
				this.gCIGJDIMNCE_ = value;
			}
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x000C88E4 File Offset: 0x000C6AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCrossInfoScRsp);
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x000C88F4 File Offset: 0x000C6AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCrossInfoScRsp other)
		{
			return other != null && (other == this || (this.RoomId == other.RoomId && this.MGAIAJAKPEI == other.MGAIAJAKPEI && this.Retcode == other.Retcode && this.GCIGJDIMNCE == other.GCIGJDIMNCE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x000C8960 File Offset: 0x000C6B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoomId != 0UL)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num ^= this.MGAIAJAKPEI.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.GCIGJDIMNCE != 0UL)
			{
				num ^= this.GCIGJDIMNCE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x000C89F0 File Offset: 0x000C6BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x000C89F8 File Offset: 0x000C6BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x000C8A04 File Offset: 0x000C6C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.MGAIAJAKPEI);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GCIGJDIMNCE != 0UL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.GCIGJDIMNCE);
			}
			if (this.RoomId != 0UL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x000C8A98 File Offset: 0x000C6C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoomId != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RoomId);
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MGAIAJAKPEI);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.GCIGJDIMNCE != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GCIGJDIMNCE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x000C8B20 File Offset: 0x000C6D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCrossInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoomId != 0UL)
			{
				this.RoomId = other.RoomId;
			}
			if (other.MGAIAJAKPEI != FightGameMode.None)
			{
				this.MGAIAJAKPEI = other.MGAIAJAKPEI;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.GCIGJDIMNCE != 0UL)
			{
				this.GCIGJDIMNCE = other.GCIGJDIMNCE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x000C8B98 File Offset: 0x000C6D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x000C8BA4 File Offset: 0x000C6DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 64U)
					{
						this.MGAIAJAKPEI = (FightGameMode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.GCIGJDIMNCE = input.ReadUInt64();
						continue;
					}
					if (num == 112U)
					{
						this.RoomId = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D46 RID: 7494
		private static readonly MessageParser<GetCrossInfoScRsp> _parser = new MessageParser<GetCrossInfoScRsp>(() => new GetCrossInfoScRsp());

		// Token: 0x04001D47 RID: 7495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D48 RID: 7496
		public const int RoomIdFieldNumber = 14;

		// Token: 0x04001D49 RID: 7497
		private ulong roomId_;

		// Token: 0x04001D4A RID: 7498
		public const int MGAIAJAKPEIFieldNumber = 8;

		// Token: 0x04001D4B RID: 7499
		private FightGameMode mGAIAJAKPEI_;

		// Token: 0x04001D4C RID: 7500
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04001D4D RID: 7501
		private uint retcode_;

		// Token: 0x04001D4E RID: 7502
		public const int GCIGJDIMNCEFieldNumber = 13;

		// Token: 0x04001D4F RID: 7503
		private ulong gCIGJDIMNCE_;
	}
}
