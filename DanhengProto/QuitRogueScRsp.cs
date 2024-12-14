using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D51 RID: 3409
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitRogueScRsp : IMessage<QuitRogueScRsp>, IMessage, IEquatable<QuitRogueScRsp>, IDeepCloneable<QuitRogueScRsp>, IBufferMessage
	{
		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x06009855 RID: 38997 RVA: 0x00195E2B File Offset: 0x0019402B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitRogueScRsp> Parser
		{
			get
			{
				return QuitRogueScRsp._parser;
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x06009856 RID: 38998 RVA: 0x00195E32 File Offset: 0x00194032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitRogueScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x06009857 RID: 38999 RVA: 0x00195E44 File Offset: 0x00194044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitRogueScRsp.Descriptor;
			}
		}

		// Token: 0x06009858 RID: 39000 RVA: 0x00195E4B File Offset: 0x0019404B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitRogueScRsp()
		{
		}

		// Token: 0x06009859 RID: 39001 RVA: 0x00195E54 File Offset: 0x00194054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitRogueScRsp(QuitRogueScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
			this.rogueFinishInfo_ = ((other.rogueFinishInfo_ != null) ? other.rogueFinishInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600985A RID: 39002 RVA: 0x00195EBC File Offset: 0x001940BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitRogueScRsp Clone()
		{
			return new QuitRogueScRsp(this);
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x0600985B RID: 39003 RVA: 0x00195EC4 File Offset: 0x001940C4
		// (set) Token: 0x0600985C RID: 39004 RVA: 0x00195ECC File Offset: 0x001940CC
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

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x0600985D RID: 39005 RVA: 0x00195ED5 File Offset: 0x001940D5
		// (set) Token: 0x0600985E RID: 39006 RVA: 0x00195EDD File Offset: 0x001940DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInfo RogueGameInfo
		{
			get
			{
				return this.rogueGameInfo_;
			}
			set
			{
				this.rogueGameInfo_ = value;
			}
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x0600985F RID: 39007 RVA: 0x00195EE6 File Offset: 0x001940E6
		// (set) Token: 0x06009860 RID: 39008 RVA: 0x00195EEE File Offset: 0x001940EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFinishInfo RogueFinishInfo
		{
			get
			{
				return this.rogueFinishInfo_;
			}
			set
			{
				this.rogueFinishInfo_ = value;
			}
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x00195EF7 File Offset: 0x001940F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitRogueScRsp);
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x00195F08 File Offset: 0x00194108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitRogueScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueGameInfo, other.RogueGameInfo) && object.Equals(this.RogueFinishInfo, other.RogueFinishInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009863 RID: 39011 RVA: 0x00195F6C File Offset: 0x0019416C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueGameInfo_ != null)
			{
				num ^= this.RogueGameInfo.GetHashCode();
			}
			if (this.rogueFinishInfo_ != null)
			{
				num ^= this.RogueFinishInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009864 RID: 39012 RVA: 0x00195FD7 File Offset: 0x001941D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009865 RID: 39013 RVA: 0x00195FDF File Offset: 0x001941DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009866 RID: 39014 RVA: 0x00195FE8 File Offset: 0x001941E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueGameInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueGameInfo);
			}
			if (this.rogueFinishInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueFinishInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x00196060 File Offset: 0x00194260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueGameInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGameInfo);
			}
			if (this.rogueFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueFinishInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009868 RID: 39016 RVA: 0x001960D0 File Offset: 0x001942D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitRogueScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueGameInfo_ != null)
			{
				if (this.rogueGameInfo_ == null)
				{
					this.RogueGameInfo = new RogueInfo();
				}
				this.RogueGameInfo.MergeFrom(other.RogueGameInfo);
			}
			if (other.rogueFinishInfo_ != null)
			{
				if (this.rogueFinishInfo_ == null)
				{
					this.RogueFinishInfo = new RogueFinishInfo();
				}
				this.RogueFinishInfo.MergeFrom(other.RogueFinishInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009869 RID: 39017 RVA: 0x00196164 File Offset: 0x00194364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600986A RID: 39018 RVA: 0x00196170 File Offset: 0x00194370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 82U)
					{
						if (num != 120U)
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
						if (this.rogueFinishInfo_ == null)
						{
							this.RogueFinishInfo = new RogueFinishInfo();
						}
						input.ReadMessage(this.RogueFinishInfo);
					}
				}
				else
				{
					if (this.rogueGameInfo_ == null)
					{
						this.RogueGameInfo = new RogueInfo();
					}
					input.ReadMessage(this.RogueGameInfo);
				}
			}
		}

		// Token: 0x04003B3A RID: 15162
		private static readonly MessageParser<QuitRogueScRsp> _parser = new MessageParser<QuitRogueScRsp>(() => new QuitRogueScRsp());

		// Token: 0x04003B3B RID: 15163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B3C RID: 15164
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04003B3D RID: 15165
		private uint retcode_;

		// Token: 0x04003B3E RID: 15166
		public const int RogueGameInfoFieldNumber = 7;

		// Token: 0x04003B3F RID: 15167
		private RogueInfo rogueGameInfo_;

		// Token: 0x04003B40 RID: 15168
		public const int RogueFinishInfoFieldNumber = 10;

		// Token: 0x04003B41 RID: 15169
		private RogueFinishInfo rogueFinishInfo_;
	}
}
