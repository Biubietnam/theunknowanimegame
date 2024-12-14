using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000157 RID: 343
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuyRogueShopMiracleScRsp : IMessage<BuyRogueShopMiracleScRsp>, IMessage, IEquatable<BuyRogueShopMiracleScRsp>, IDeepCloneable<BuyRogueShopMiracleScRsp>, IBufferMessage
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x0002D20D File Offset: 0x0002B40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuyRogueShopMiracleScRsp> Parser
		{
			get
			{
				return BuyRogueShopMiracleScRsp._parser;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0002D214 File Offset: 0x0002B414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuyRogueShopMiracleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x0002D226 File Offset: 0x0002B426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuyRogueShopMiracleScRsp.Descriptor;
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0002D22D File Offset: 0x0002B42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyRogueShopMiracleScRsp()
		{
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0002D238 File Offset: 0x0002B438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyRogueShopMiracleScRsp(BuyRogueShopMiracleScRsp other) : this()
		{
			this.gameMiracleInfo_ = ((other.gameMiracleInfo_ != null) ? other.gameMiracleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0002D284 File Offset: 0x0002B484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyRogueShopMiracleScRsp Clone()
		{
			return new BuyRogueShopMiracleScRsp(this);
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x0002D28C File Offset: 0x0002B48C
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x0002D294 File Offset: 0x0002B494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COOCBDAINLK GameMiracleInfo
		{
			get
			{
				return this.gameMiracleInfo_;
			}
			set
			{
				this.gameMiracleInfo_ = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x0002D29D File Offset: 0x0002B49D
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x0002D2A5 File Offset: 0x0002B4A5
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

		// Token: 0x06000F5D RID: 3933 RVA: 0x0002D2AE File Offset: 0x0002B4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuyRogueShopMiracleScRsp);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0002D2BC File Offset: 0x0002B4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuyRogueShopMiracleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GameMiracleInfo, other.GameMiracleInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0002D30C File Offset: 0x0002B50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gameMiracleInfo_ != null)
			{
				num ^= this.GameMiracleInfo.GetHashCode();
			}
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

		// Token: 0x06000F60 RID: 3936 RVA: 0x0002D361 File Offset: 0x0002B561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0002D369 File Offset: 0x0002B569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0002D374 File Offset: 0x0002B574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.gameMiracleInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.GameMiracleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0002D3D0 File Offset: 0x0002B5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gameMiracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameMiracleInfo);
			}
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

		// Token: 0x06000F64 RID: 3940 RVA: 0x0002D428 File Offset: 0x0002B628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuyRogueShopMiracleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gameMiracleInfo_ != null)
			{
				if (this.gameMiracleInfo_ == null)
				{
					this.GameMiracleInfo = new COOCBDAINLK();
				}
				this.GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0002D490 File Offset: 0x0002B690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0002D49C File Offset: 0x0002B69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gameMiracleInfo_ == null)
						{
							this.GameMiracleInfo = new COOCBDAINLK();
						}
						input.ReadMessage(this.GameMiracleInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000695 RID: 1685
		private static readonly MessageParser<BuyRogueShopMiracleScRsp> _parser = new MessageParser<BuyRogueShopMiracleScRsp>(() => new BuyRogueShopMiracleScRsp());

		// Token: 0x04000696 RID: 1686
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000697 RID: 1687
		public const int GameMiracleInfoFieldNumber = 14;

		// Token: 0x04000698 RID: 1688
		private COOCBDAINLK gameMiracleInfo_;

		// Token: 0x04000699 RID: 1689
		public const int RetcodeFieldNumber = 11;

		// Token: 0x0400069A RID: 1690
		private uint retcode_;
	}
}
