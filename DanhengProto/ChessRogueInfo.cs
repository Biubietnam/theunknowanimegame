using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000231 RID: 561
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueInfo : IMessage<ChessRogueInfo>, IMessage, IEquatable<ChessRogueInfo>, IDeepCloneable<ChessRogueInfo>, IBufferMessage
	{
		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x0004979D File Offset: 0x0004799D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueInfo> Parser
		{
			get
			{
				return ChessRogueInfo._parser;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x000497A4 File Offset: 0x000479A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x000497B6 File Offset: 0x000479B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueInfo.Descriptor;
			}
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x000497BD File Offset: 0x000479BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueInfo()
		{
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000497C8 File Offset: 0x000479C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueInfo(ChessRogueInfo other) : this()
		{
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00049824 File Offset: 0x00047A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueInfo Clone()
		{
			return new ChessRogueInfo(this);
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x0004982C File Offset: 0x00047A2C
		// (set) Token: 0x06001947 RID: 6471 RVA: 0x00049834 File Offset: 0x00047A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x0004983D File Offset: 0x00047A3D
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x00049845 File Offset: 0x00047A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0004984E File Offset: 0x00047A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueInfo);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0004985C File Offset: 0x00047A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Lineup, other.Lineup) && object.Equals(this.Scene, other.Scene) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000498B0 File Offset: 0x00047AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00049902 File Offset: 0x00047B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0004990A File Offset: 0x00047B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00049914 File Offset: 0x00047B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lineup_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Lineup);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00049970 File Offset: 0x00047B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000499C8 File Offset: 0x00047BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00049A48 File Offset: 0x00047C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00049A54 File Offset: 0x00047C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
					}
				}
				else
				{
					if (this.lineup_ == null)
					{
						this.Lineup = new LineupInfo();
					}
					input.ReadMessage(this.Lineup);
				}
			}
		}

		// Token: 0x04000AC0 RID: 2752
		private static readonly MessageParser<ChessRogueInfo> _parser = new MessageParser<ChessRogueInfo>(() => new ChessRogueInfo());

		// Token: 0x04000AC1 RID: 2753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AC2 RID: 2754
		public const int LineupFieldNumber = 1;

		// Token: 0x04000AC3 RID: 2755
		private LineupInfo lineup_;

		// Token: 0x04000AC4 RID: 2756
		public const int SceneFieldNumber = 15;

		// Token: 0x04000AC5 RID: 2757
		private SceneInfo scene_;
	}
}
