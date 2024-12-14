using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001081 RID: 4225
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneNpcInfo : IMessage<SceneNpcInfo>, IMessage, IEquatable<SceneNpcInfo>, IDeepCloneable<SceneNpcInfo>, IBufferMessage
	{
		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x0600BC52 RID: 48210 RVA: 0x001FB869 File Offset: 0x001F9A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneNpcInfo> Parser
		{
			get
			{
				return SceneNpcInfo._parser;
			}
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x0600BC53 RID: 48211 RVA: 0x001FB870 File Offset: 0x001F9A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneNpcInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x0600BC54 RID: 48212 RVA: 0x001FB882 File Offset: 0x001F9A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneNpcInfo.Descriptor;
			}
		}

		// Token: 0x0600BC55 RID: 48213 RVA: 0x001FB889 File Offset: 0x001F9A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneNpcInfo()
		{
		}

		// Token: 0x0600BC56 RID: 48214 RVA: 0x001FB894 File Offset: 0x001F9A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneNpcInfo(SceneNpcInfo other) : this()
		{
			this.extraInfo_ = ((other.extraInfo_ != null) ? other.extraInfo_.Clone() : null);
			this.npcId_ = other.npcId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC57 RID: 48215 RVA: 0x001FB8E0 File Offset: 0x001F9AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneNpcInfo Clone()
		{
			return new SceneNpcInfo(this);
		}

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x001FB8E8 File Offset: 0x001F9AE8
		// (set) Token: 0x0600BC59 RID: 48217 RVA: 0x001FB8F0 File Offset: 0x001F9AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcExtraInfo ExtraInfo
		{
			get
			{
				return this.extraInfo_;
			}
			set
			{
				this.extraInfo_ = value;
			}
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x0600BC5A RID: 48218 RVA: 0x001FB8F9 File Offset: 0x001F9AF9
		// (set) Token: 0x0600BC5B RID: 48219 RVA: 0x001FB901 File Offset: 0x001F9B01
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

		// Token: 0x0600BC5C RID: 48220 RVA: 0x001FB90A File Offset: 0x001F9B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneNpcInfo);
		}

		// Token: 0x0600BC5D RID: 48221 RVA: 0x001FB918 File Offset: 0x001F9B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneNpcInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ExtraInfo, other.ExtraInfo) && this.NpcId == other.NpcId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC5E RID: 48222 RVA: 0x001FB968 File Offset: 0x001F9B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.extraInfo_ != null)
			{
				num ^= this.ExtraInfo.GetHashCode();
			}
			if (this.NpcId != 0U)
			{
				num ^= this.NpcId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC5F RID: 48223 RVA: 0x001FB9BD File Offset: 0x001F9BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BC60 RID: 48224 RVA: 0x001FB9C5 File Offset: 0x001F9BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC61 RID: 48225 RVA: 0x001FB9D0 File Offset: 0x001F9BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.extraInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ExtraInfo);
			}
			if (this.NpcId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.NpcId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC62 RID: 48226 RVA: 0x001FBA2C File Offset: 0x001F9C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.extraInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ExtraInfo);
			}
			if (this.NpcId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NpcId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC63 RID: 48227 RVA: 0x001FBA84 File Offset: 0x001F9C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneNpcInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.extraInfo_ != null)
			{
				if (this.extraInfo_ == null)
				{
					this.ExtraInfo = new NpcExtraInfo();
				}
				this.ExtraInfo.MergeFrom(other.ExtraInfo);
			}
			if (other.NpcId != 0U)
			{
				this.NpcId = other.NpcId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x001FBAEC File Offset: 0x001F9CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC65 RID: 48229 RVA: 0x001FBAF8 File Offset: 0x001F9CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NpcId = input.ReadUInt32();
					}
				}
				else
				{
					if (this.extraInfo_ == null)
					{
						this.ExtraInfo = new NpcExtraInfo();
					}
					input.ReadMessage(this.ExtraInfo);
				}
			}
		}

		// Token: 0x04004C97 RID: 19607
		private static readonly MessageParser<SceneNpcInfo> _parser = new MessageParser<SceneNpcInfo>(() => new SceneNpcInfo());

		// Token: 0x04004C98 RID: 19608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C99 RID: 19609
		public const int ExtraInfoFieldNumber = 4;

		// Token: 0x04004C9A RID: 19610
		private NpcExtraInfo extraInfo_;

		// Token: 0x04004C9B RID: 19611
		public const int NpcIdFieldNumber = 9;

		// Token: 0x04004C9C RID: 19612
		private uint npcId_;
	}
}
