using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200107F RID: 4223
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneMonsterWaveParam : IMessage<SceneMonsterWaveParam>, IMessage, IEquatable<SceneMonsterWaveParam>, IDeepCloneable<SceneMonsterWaveParam>, IBufferMessage
	{
		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0600BC37 RID: 48183 RVA: 0x001FB3C9 File Offset: 0x001F95C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneMonsterWaveParam> Parser
		{
			get
			{
				return SceneMonsterWaveParam._parser;
			}
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x0600BC38 RID: 48184 RVA: 0x001FB3D0 File Offset: 0x001F95D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneMonsterWaveParamReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0600BC39 RID: 48185 RVA: 0x001FB3E2 File Offset: 0x001F95E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneMonsterWaveParam.Descriptor;
			}
		}

		// Token: 0x0600BC3A RID: 48186 RVA: 0x001FB3E9 File Offset: 0x001F95E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterWaveParam()
		{
		}

		// Token: 0x0600BC3B RID: 48187 RVA: 0x001FB3F4 File Offset: 0x001F95F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterWaveParam(SceneMonsterWaveParam other) : this()
		{
			this.iIBEOENKNCN_ = other.iIBEOENKNCN_;
			this.level_ = other.level_;
			this.eliteGroup_ = other.eliteGroup_;
			this.hardLevelGroup_ = other.hardLevelGroup_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC3C RID: 48188 RVA: 0x001FB448 File Offset: 0x001F9648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterWaveParam Clone()
		{
			return new SceneMonsterWaveParam(this);
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0600BC3D RID: 48189 RVA: 0x001FB450 File Offset: 0x001F9650
		// (set) Token: 0x0600BC3E RID: 48190 RVA: 0x001FB458 File Offset: 0x001F9658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IIBEOENKNCN
		{
			get
			{
				return this.iIBEOENKNCN_;
			}
			set
			{
				this.iIBEOENKNCN_ = value;
			}
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x0600BC3F RID: 48191 RVA: 0x001FB461 File Offset: 0x001F9661
		// (set) Token: 0x0600BC40 RID: 48192 RVA: 0x001FB469 File Offset: 0x001F9669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x0600BC41 RID: 48193 RVA: 0x001FB472 File Offset: 0x001F9672
		// (set) Token: 0x0600BC42 RID: 48194 RVA: 0x001FB47A File Offset: 0x001F967A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EliteGroup
		{
			get
			{
				return this.eliteGroup_;
			}
			set
			{
				this.eliteGroup_ = value;
			}
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x0600BC43 RID: 48195 RVA: 0x001FB483 File Offset: 0x001F9683
		// (set) Token: 0x0600BC44 RID: 48196 RVA: 0x001FB48B File Offset: 0x001F968B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HardLevelGroup
		{
			get
			{
				return this.hardLevelGroup_;
			}
			set
			{
				this.hardLevelGroup_ = value;
			}
		}

		// Token: 0x0600BC45 RID: 48197 RVA: 0x001FB494 File Offset: 0x001F9694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneMonsterWaveParam);
		}

		// Token: 0x0600BC46 RID: 48198 RVA: 0x001FB4A4 File Offset: 0x001F96A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneMonsterWaveParam other)
		{
			return other != null && (other == this || (this.IIBEOENKNCN == other.IIBEOENKNCN && this.Level == other.Level && this.EliteGroup == other.EliteGroup && this.HardLevelGroup == other.HardLevelGroup && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC47 RID: 48199 RVA: 0x001FB510 File Offset: 0x001F9710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IIBEOENKNCN != 0U)
			{
				num ^= this.IIBEOENKNCN.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.EliteGroup != 0U)
			{
				num ^= this.EliteGroup.GetHashCode();
			}
			if (this.HardLevelGroup != 0U)
			{
				num ^= this.HardLevelGroup.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC48 RID: 48200 RVA: 0x001FB59A File Offset: 0x001F979A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BC49 RID: 48201 RVA: 0x001FB5A2 File Offset: 0x001F97A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC4A RID: 48202 RVA: 0x001FB5AC File Offset: 0x001F97AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IIBEOENKNCN != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.IIBEOENKNCN);
			}
			if (this.HardLevelGroup != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.HardLevelGroup);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Level);
			}
			if (this.EliteGroup != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.EliteGroup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC4B RID: 48203 RVA: 0x001FB63C File Offset: 0x001F983C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IIBEOENKNCN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IIBEOENKNCN);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.EliteGroup != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EliteGroup);
			}
			if (this.HardLevelGroup != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HardLevelGroup);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC4C RID: 48204 RVA: 0x001FB6C4 File Offset: 0x001F98C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneMonsterWaveParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IIBEOENKNCN != 0U)
			{
				this.IIBEOENKNCN = other.IIBEOENKNCN;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.EliteGroup != 0U)
			{
				this.EliteGroup = other.EliteGroup;
			}
			if (other.HardLevelGroup != 0U)
			{
				this.HardLevelGroup = other.HardLevelGroup;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC4D RID: 48205 RVA: 0x001FB73C File Offset: 0x001F993C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC4E RID: 48206 RVA: 0x001FB748 File Offset: 0x001F9948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 8U)
					{
						this.IIBEOENKNCN = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.HardLevelGroup = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.EliteGroup = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C8C RID: 19596
		private static readonly MessageParser<SceneMonsterWaveParam> _parser = new MessageParser<SceneMonsterWaveParam>(() => new SceneMonsterWaveParam());

		// Token: 0x04004C8D RID: 19597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C8E RID: 19598
		public const int IIBEOENKNCNFieldNumber = 1;

		// Token: 0x04004C8F RID: 19599
		private uint iIBEOENKNCN_;

		// Token: 0x04004C90 RID: 19600
		public const int LevelFieldNumber = 11;

		// Token: 0x04004C91 RID: 19601
		private uint level_;

		// Token: 0x04004C92 RID: 19602
		public const int EliteGroupFieldNumber = 13;

		// Token: 0x04004C93 RID: 19603
		private uint eliteGroup_;

		// Token: 0x04004C94 RID: 19604
		public const int HardLevelGroupFieldNumber = 10;

		// Token: 0x04004C95 RID: 19605
		private uint hardLevelGroup_;
	}
}
