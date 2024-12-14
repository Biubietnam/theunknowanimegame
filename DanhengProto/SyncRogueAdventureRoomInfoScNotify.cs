using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200127B RID: 4731
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueAdventureRoomInfoScNotify : IMessage<SyncRogueAdventureRoomInfoScNotify>, IMessage, IEquatable<SyncRogueAdventureRoomInfoScNotify>, IDeepCloneable<SyncRogueAdventureRoomInfoScNotify>, IBufferMessage
	{
		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x0600D315 RID: 54037 RVA: 0x00233D97 File Offset: 0x00231F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueAdventureRoomInfoScNotify> Parser
		{
			get
			{
				return SyncRogueAdventureRoomInfoScNotify._parser;
			}
		}

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x0600D316 RID: 54038 RVA: 0x00233D9E File Offset: 0x00231F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueAdventureRoomInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x0600D317 RID: 54039 RVA: 0x00233DB0 File Offset: 0x00231FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueAdventureRoomInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600D318 RID: 54040 RVA: 0x00233DB7 File Offset: 0x00231FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAdventureRoomInfoScNotify()
		{
		}

		// Token: 0x0600D319 RID: 54041 RVA: 0x00233DBF File Offset: 0x00231FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAdventureRoomInfoScNotify(SyncRogueAdventureRoomInfoScNotify other) : this()
		{
			this.adventureRoomInfo_ = ((other.adventureRoomInfo_ != null) ? other.adventureRoomInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D31A RID: 54042 RVA: 0x00233DF4 File Offset: 0x00231FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAdventureRoomInfoScNotify Clone()
		{
			return new SyncRogueAdventureRoomInfoScNotify(this);
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x0600D31B RID: 54043 RVA: 0x00233DFC File Offset: 0x00231FFC
		// (set) Token: 0x0600D31C RID: 54044 RVA: 0x00233E04 File Offset: 0x00232004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRoomInfo AdventureRoomInfo
		{
			get
			{
				return this.adventureRoomInfo_;
			}
			set
			{
				this.adventureRoomInfo_ = value;
			}
		}

		// Token: 0x0600D31D RID: 54045 RVA: 0x00233E0D File Offset: 0x0023200D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueAdventureRoomInfoScNotify);
		}

		// Token: 0x0600D31E RID: 54046 RVA: 0x00233E1B File Offset: 0x0023201B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueAdventureRoomInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.AdventureRoomInfo, other.AdventureRoomInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D31F RID: 54047 RVA: 0x00233E50 File Offset: 0x00232050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.adventureRoomInfo_ != null)
			{
				num ^= this.AdventureRoomInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D320 RID: 54048 RVA: 0x00233E8C File Offset: 0x0023208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D321 RID: 54049 RVA: 0x00233E94 File Offset: 0x00232094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D322 RID: 54050 RVA: 0x00233E9D File Offset: 0x0023209D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.adventureRoomInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.AdventureRoomInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D323 RID: 54051 RVA: 0x00233ED0 File Offset: 0x002320D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.adventureRoomInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AdventureRoomInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D324 RID: 54052 RVA: 0x00233F10 File Offset: 0x00232110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueAdventureRoomInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.adventureRoomInfo_ != null)
			{
				if (this.adventureRoomInfo_ == null)
				{
					this.AdventureRoomInfo = new AdventureRoomInfo();
				}
				this.AdventureRoomInfo.MergeFrom(other.AdventureRoomInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D325 RID: 54053 RVA: 0x00233F64 File Offset: 0x00232164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D326 RID: 54054 RVA: 0x00233F70 File Offset: 0x00232170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.adventureRoomInfo_ == null)
					{
						this.AdventureRoomInfo = new AdventureRoomInfo();
					}
					input.ReadMessage(this.AdventureRoomInfo);
				}
			}
		}

		// Token: 0x0400548D RID: 21645
		private static readonly MessageParser<SyncRogueAdventureRoomInfoScNotify> _parser = new MessageParser<SyncRogueAdventureRoomInfoScNotify>(() => new SyncRogueAdventureRoomInfoScNotify());

		// Token: 0x0400548E RID: 21646
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400548F RID: 21647
		public const int AdventureRoomInfoFieldNumber = 15;

		// Token: 0x04005490 RID: 21648
		private AdventureRoomInfo adventureRoomInfo_;
	}
}
