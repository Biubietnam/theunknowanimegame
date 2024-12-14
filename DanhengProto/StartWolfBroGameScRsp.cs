using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011DF RID: 4575
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartWolfBroGameScRsp : IMessage<StartWolfBroGameScRsp>, IMessage, IEquatable<StartWolfBroGameScRsp>, IDeepCloneable<StartWolfBroGameScRsp>, IBufferMessage
	{
		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0600CC84 RID: 52356 RVA: 0x00224E91 File Offset: 0x00223091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartWolfBroGameScRsp> Parser
		{
			get
			{
				return StartWolfBroGameScRsp._parser;
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0600CC85 RID: 52357 RVA: 0x00224E98 File Offset: 0x00223098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartWolfBroGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0600CC86 RID: 52358 RVA: 0x00224EAA File Offset: 0x002230AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartWolfBroGameScRsp.Descriptor;
			}
		}

		// Token: 0x0600CC87 RID: 52359 RVA: 0x00224EB1 File Offset: 0x002230B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartWolfBroGameScRsp()
		{
		}

		// Token: 0x0600CC88 RID: 52360 RVA: 0x00224EBC File Offset: 0x002230BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartWolfBroGameScRsp(StartWolfBroGameScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.wolfBroGameData_ = ((other.wolfBroGameData_ != null) ? other.wolfBroGameData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC89 RID: 52361 RVA: 0x00224F08 File Offset: 0x00223108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartWolfBroGameScRsp Clone()
		{
			return new StartWolfBroGameScRsp(this);
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x0600CC8A RID: 52362 RVA: 0x00224F10 File Offset: 0x00223110
		// (set) Token: 0x0600CC8B RID: 52363 RVA: 0x00224F18 File Offset: 0x00223118
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

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0600CC8C RID: 52364 RVA: 0x00224F21 File Offset: 0x00223121
		// (set) Token: 0x0600CC8D RID: 52365 RVA: 0x00224F29 File Offset: 0x00223129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData WolfBroGameData
		{
			get
			{
				return this.wolfBroGameData_;
			}
			set
			{
				this.wolfBroGameData_ = value;
			}
		}

		// Token: 0x0600CC8E RID: 52366 RVA: 0x00224F32 File Offset: 0x00223132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartWolfBroGameScRsp);
		}

		// Token: 0x0600CC8F RID: 52367 RVA: 0x00224F40 File Offset: 0x00223140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartWolfBroGameScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.WolfBroGameData, other.WolfBroGameData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC90 RID: 52368 RVA: 0x00224F90 File Offset: 0x00223190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.wolfBroGameData_ != null)
			{
				num ^= this.WolfBroGameData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC91 RID: 52369 RVA: 0x00224FE5 File Offset: 0x002231E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CC92 RID: 52370 RVA: 0x00224FED File Offset: 0x002231ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC93 RID: 52371 RVA: 0x00224FF8 File Offset: 0x002231F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.wolfBroGameData_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC94 RID: 52372 RVA: 0x00225054 File Offset: 0x00223254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.wolfBroGameData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC95 RID: 52373 RVA: 0x002250AC File Offset: 0x002232AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartWolfBroGameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.wolfBroGameData_ != null)
			{
				if (this.wolfBroGameData_ == null)
				{
					this.WolfBroGameData = new WolfBroGameData();
				}
				this.WolfBroGameData.MergeFrom(other.WolfBroGameData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC96 RID: 52374 RVA: 0x00225114 File Offset: 0x00223314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC97 RID: 52375 RVA: 0x00225120 File Offset: 0x00223320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.wolfBroGameData_ == null)
						{
							this.WolfBroGameData = new WolfBroGameData();
						}
						input.ReadMessage(this.WolfBroGameData);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005276 RID: 21110
		private static readonly MessageParser<StartWolfBroGameScRsp> _parser = new MessageParser<StartWolfBroGameScRsp>(() => new StartWolfBroGameScRsp());

		// Token: 0x04005277 RID: 21111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005278 RID: 21112
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04005279 RID: 21113
		private uint retcode_;

		// Token: 0x0400527A RID: 21114
		public const int WolfBroGameDataFieldNumber = 10;

		// Token: 0x0400527B RID: 21115
		private WolfBroGameData wolfBroGameData_;
	}
}
