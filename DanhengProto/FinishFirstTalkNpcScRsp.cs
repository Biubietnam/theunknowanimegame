using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000581 RID: 1409
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishFirstTalkNpcScRsp : IMessage<FinishFirstTalkNpcScRsp>, IMessage, IEquatable<FinishFirstTalkNpcScRsp>, IDeepCloneable<FinishFirstTalkNpcScRsp>, IBufferMessage
	{
		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x000ABBD4 File Offset: 0x000A9DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishFirstTalkNpcScRsp> Parser
		{
			get
			{
				return FinishFirstTalkNpcScRsp._parser;
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x000ABBDB File Offset: 0x000A9DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishFirstTalkNpcScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x000ABBED File Offset: 0x000A9DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishFirstTalkNpcScRsp.Descriptor;
			}
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x000ABBF4 File Offset: 0x000A9DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkNpcScRsp()
		{
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x000ABBFC File Offset: 0x000A9DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkNpcScRsp(FinishFirstTalkNpcScRsp other) : this()
		{
			this.npcId_ = other.npcId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x000ABC2D File Offset: 0x000A9E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkNpcScRsp Clone()
		{
			return new FinishFirstTalkNpcScRsp(this);
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06003EE4 RID: 16100 RVA: 0x000ABC35 File Offset: 0x000A9E35
		// (set) Token: 0x06003EE5 RID: 16101 RVA: 0x000ABC3D File Offset: 0x000A9E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NpcId
		{
			get
			{
				return this.npcId_;
			}
			set
			{
				this.npcId_ = value;
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06003EE6 RID: 16102 RVA: 0x000ABC46 File Offset: 0x000A9E46
		// (set) Token: 0x06003EE7 RID: 16103 RVA: 0x000ABC4E File Offset: 0x000A9E4E
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

		// Token: 0x06003EE8 RID: 16104 RVA: 0x000ABC57 File Offset: 0x000A9E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishFirstTalkNpcScRsp);
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x000ABC65 File Offset: 0x000A9E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishFirstTalkNpcScRsp other)
		{
			return other != null && (other == this || (this.NpcId == other.NpcId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x000ABCA4 File Offset: 0x000A9EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NpcId != 0U)
			{
				num ^= this.NpcId.GetHashCode();
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

		// Token: 0x06003EEB RID: 16107 RVA: 0x000ABCFC File Offset: 0x000A9EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x000ABD04 File Offset: 0x000A9F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x000ABD10 File Offset: 0x000A9F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NpcId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.NpcId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x000ABD6C File Offset: 0x000A9F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NpcId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NpcId);
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

		// Token: 0x06003EEF RID: 16111 RVA: 0x000ABDC4 File Offset: 0x000A9FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishFirstTalkNpcScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NpcId != 0U)
			{
				this.NpcId = other.NpcId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x000ABE14 File Offset: 0x000AA014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x000ABE20 File Offset: 0x000AA020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 40U)
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
					this.NpcId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400190F RID: 6415
		private static readonly MessageParser<FinishFirstTalkNpcScRsp> _parser = new MessageParser<FinishFirstTalkNpcScRsp>(() => new FinishFirstTalkNpcScRsp());

		// Token: 0x04001910 RID: 6416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001911 RID: 6417
		public const int NpcIdFieldNumber = 4;

		// Token: 0x04001912 RID: 6418
		private uint npcId_;

		// Token: 0x04001913 RID: 6419
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001914 RID: 6420
		private uint retcode_;
	}
}
