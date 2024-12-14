using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001083 RID: 4227
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneNpcMonsterInfo : IMessage<SceneNpcMonsterInfo>, IMessage, IEquatable<SceneNpcMonsterInfo>, IDeepCloneable<SceneNpcMonsterInfo>, IBufferMessage
	{
		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x0600BC69 RID: 48233 RVA: 0x001FBC43 File Offset: 0x001F9E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneNpcMonsterInfo> Parser
		{
			get
			{
				return SceneNpcMonsterInfo._parser;
			}
		}

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x0600BC6A RID: 48234 RVA: 0x001FBC4A File Offset: 0x001F9E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneNpcMonsterInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x0600BC6B RID: 48235 RVA: 0x001FBC5C File Offset: 0x001F9E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneNpcMonsterInfo.Descriptor;
			}
		}

		// Token: 0x0600BC6C RID: 48236 RVA: 0x001FBC63 File Offset: 0x001F9E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneNpcMonsterInfo()
		{
		}

		// Token: 0x0600BC6D RID: 48237 RVA: 0x001FBC6C File Offset: 0x001F9E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneNpcMonsterInfo(SceneNpcMonsterInfo other) : this()
		{
			this.extraInfo_ = ((other.extraInfo_ != null) ? other.extraInfo_.Clone() : null);
			this.worldLevel_ = other.worldLevel_;
			this.lLNDHNIGJMI_ = other.lLNDHNIGJMI_;
			this.hHGJLELADKO_ = other.hHGJLELADKO_;
			this.monsterId_ = other.monsterId_;
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC6E RID: 48238 RVA: 0x001FBCE8 File Offset: 0x001F9EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneNpcMonsterInfo Clone()
		{
			return new SceneNpcMonsterInfo(this);
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x0600BC6F RID: 48239 RVA: 0x001FBCF0 File Offset: 0x001F9EF0
		// (set) Token: 0x0600BC70 RID: 48240 RVA: 0x001FBCF8 File Offset: 0x001F9EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMonsterExtraInfo ExtraInfo
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

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x0600BC71 RID: 48241 RVA: 0x001FBD01 File Offset: 0x001F9F01
		// (set) Token: 0x0600BC72 RID: 48242 RVA: 0x001FBD09 File Offset: 0x001F9F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x0600BC73 RID: 48243 RVA: 0x001FBD12 File Offset: 0x001F9F12
		// (set) Token: 0x0600BC74 RID: 48244 RVA: 0x001FBD1A File Offset: 0x001F9F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LLNDHNIGJMI
		{
			get
			{
				return this.lLNDHNIGJMI_;
			}
			set
			{
				this.lLNDHNIGJMI_ = value;
			}
		}

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x0600BC75 RID: 48245 RVA: 0x001FBD23 File Offset: 0x001F9F23
		// (set) Token: 0x0600BC76 RID: 48246 RVA: 0x001FBD2B File Offset: 0x001F9F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HHGJLELADKO
		{
			get
			{
				return this.hHGJLELADKO_;
			}
			set
			{
				this.hHGJLELADKO_ = value;
			}
		}

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0600BC77 RID: 48247 RVA: 0x001FBD34 File Offset: 0x001F9F34
		// (set) Token: 0x0600BC78 RID: 48248 RVA: 0x001FBD3C File Offset: 0x001F9F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x0600BC79 RID: 48249 RVA: 0x001FBD45 File Offset: 0x001F9F45
		// (set) Token: 0x0600BC7A RID: 48250 RVA: 0x001FBD4D File Offset: 0x001F9F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x0600BC7B RID: 48251 RVA: 0x001FBD56 File Offset: 0x001F9F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneNpcMonsterInfo);
		}

		// Token: 0x0600BC7C RID: 48252 RVA: 0x001FBD64 File Offset: 0x001F9F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneNpcMonsterInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ExtraInfo, other.ExtraInfo) && this.WorldLevel == other.WorldLevel && this.LLNDHNIGJMI == other.LLNDHNIGJMI && this.HHGJLELADKO == other.HHGJLELADKO && this.MonsterId == other.MonsterId && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x001FBDF4 File Offset: 0x001F9FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.extraInfo_ != null)
			{
				num ^= this.ExtraInfo.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.LLNDHNIGJMI)
			{
				num ^= this.LLNDHNIGJMI.GetHashCode();
			}
			if (this.HHGJLELADKO)
			{
				num ^= this.HHGJLELADKO.GetHashCode();
			}
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x001FBEAD File Offset: 0x001FA0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BC7F RID: 48255 RVA: 0x001FBEB5 File Offset: 0x001FA0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC80 RID: 48256 RVA: 0x001FBEC0 File Offset: 0x001FA0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.EventId);
			}
			if (this.extraInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ExtraInfo);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MonsterId);
			}
			if (this.LLNDHNIGJMI)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.LLNDHNIGJMI);
			}
			if (this.HHGJLELADKO)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.HHGJLELADKO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC81 RID: 48257 RVA: 0x001FBF8C File Offset: 0x001FA18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.extraInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ExtraInfo);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.LLNDHNIGJMI)
			{
				num += 2;
			}
			if (this.HHGJLELADKO)
			{
				num += 2;
			}
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC82 RID: 48258 RVA: 0x001FC02C File Offset: 0x001FA22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneNpcMonsterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.extraInfo_ != null)
			{
				if (this.extraInfo_ == null)
				{
					this.ExtraInfo = new NpcMonsterExtraInfo();
				}
				this.ExtraInfo.MergeFrom(other.ExtraInfo);
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.LLNDHNIGJMI)
			{
				this.LLNDHNIGJMI = other.LLNDHNIGJMI;
			}
			if (other.HHGJLELADKO)
			{
				this.HHGJLELADKO = other.HHGJLELADKO;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC83 RID: 48259 RVA: 0x001FC0E4 File Offset: 0x001FA2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC84 RID: 48260 RVA: 0x001FC0F0 File Offset: 0x001FA2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.extraInfo_ == null)
						{
							this.ExtraInfo = new NpcMonsterExtraInfo();
						}
						input.ReadMessage(this.ExtraInfo);
						continue;
					}
					if (num == 40U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.MonsterId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.LLNDHNIGJMI = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.HHGJLELADKO = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C9E RID: 19614
		private static readonly MessageParser<SceneNpcMonsterInfo> _parser = new MessageParser<SceneNpcMonsterInfo>(() => new SceneNpcMonsterInfo());

		// Token: 0x04004C9F RID: 19615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CA0 RID: 19616
		public const int ExtraInfoFieldNumber = 4;

		// Token: 0x04004CA1 RID: 19617
		private NpcMonsterExtraInfo extraInfo_;

		// Token: 0x04004CA2 RID: 19618
		public const int WorldLevelFieldNumber = 5;

		// Token: 0x04004CA3 RID: 19619
		private uint worldLevel_;

		// Token: 0x04004CA4 RID: 19620
		public const int LLNDHNIGJMIFieldNumber = 12;

		// Token: 0x04004CA5 RID: 19621
		private bool lLNDHNIGJMI_;

		// Token: 0x04004CA6 RID: 19622
		public const int HHGJLELADKOFieldNumber = 13;

		// Token: 0x04004CA7 RID: 19623
		private bool hHGJLELADKO_;

		// Token: 0x04004CA8 RID: 19624
		public const int MonsterIdFieldNumber = 7;

		// Token: 0x04004CA9 RID: 19625
		private uint monsterId_;

		// Token: 0x04004CAA RID: 19626
		public const int EventIdFieldNumber = 2;

		// Token: 0x04004CAB RID: 19627
		private uint eventId_;
	}
}
