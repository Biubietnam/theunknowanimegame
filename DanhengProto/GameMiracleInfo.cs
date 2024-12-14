using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005D7 RID: 1495
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameMiracleInfo : IMessage<GameMiracleInfo>, IMessage, IEquatable<GameMiracleInfo>, IDeepCloneable<GameMiracleInfo>, IBufferMessage
	{
		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x000B5FCD File Offset: 0x000B41CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameMiracleInfo> Parser
		{
			get
			{
				return GameMiracleInfo._parser;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x060042C7 RID: 17095 RVA: 0x000B5FD4 File Offset: 0x000B41D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMiracleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x060042C8 RID: 17096 RVA: 0x000B5FE6 File Offset: 0x000B41E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameMiracleInfo.Descriptor;
			}
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x000B5FED File Offset: 0x000B41ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameMiracleInfo()
		{
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x000B5FF5 File Offset: 0x000B41F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameMiracleInfo(GameMiracleInfo other) : this()
		{
			this.gameMiracleInfo_ = ((other.gameMiracleInfo_ != null) ? other.gameMiracleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x000B602A File Offset: 0x000B422A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameMiracleInfo Clone()
		{
			return new GameMiracleInfo(this);
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x000B6032 File Offset: 0x000B4232
		// (set) Token: 0x060042CD RID: 17101 RVA: 0x000B603A File Offset: 0x000B423A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleInfo GameMiracleInfo_
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

		// Token: 0x060042CE RID: 17102 RVA: 0x000B6043 File Offset: 0x000B4243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameMiracleInfo);
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x000B6051 File Offset: 0x000B4251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameMiracleInfo other)
		{
			return other != null && (other == this || (object.Equals(this.GameMiracleInfo_, other.GameMiracleInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x000B6084 File Offset: 0x000B4284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gameMiracleInfo_ != null)
			{
				num ^= this.GameMiracleInfo_.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x000B60C0 File Offset: 0x000B42C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x000B60C8 File Offset: 0x000B42C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x000B60D1 File Offset: 0x000B42D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameMiracleInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GameMiracleInfo_);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x000B6104 File Offset: 0x000B4304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gameMiracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameMiracleInfo_);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x000B6144 File Offset: 0x000B4344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameMiracleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gameMiracleInfo_ != null)
			{
				if (this.gameMiracleInfo_ == null)
				{
					this.GameMiracleInfo_ = new RogueMiracleInfo();
				}
				this.GameMiracleInfo_.MergeFrom(other.GameMiracleInfo_);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x000B6198 File Offset: 0x000B4398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x000B61A4 File Offset: 0x000B43A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.gameMiracleInfo_ == null)
					{
						this.GameMiracleInfo_ = new RogueMiracleInfo();
					}
					input.ReadMessage(this.GameMiracleInfo_);
				}
			}
		}

		// Token: 0x04001A8A RID: 6794
		private static readonly MessageParser<GameMiracleInfo> _parser = new MessageParser<GameMiracleInfo>(() => new GameMiracleInfo());

		// Token: 0x04001A8B RID: 6795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A8C RID: 6796
		public const int GameMiracleInfo_FieldNumber = 4;

		// Token: 0x04001A8D RID: 6797
		private RogueMiracleInfo gameMiracleInfo_;
	}
}
