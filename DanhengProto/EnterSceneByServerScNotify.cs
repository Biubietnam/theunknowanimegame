using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200045F RID: 1119
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterSceneByServerScNotify : IMessage<EnterSceneByServerScNotify>, IMessage, IEquatable<EnterSceneByServerScNotify>, IDeepCloneable<EnterSceneByServerScNotify>, IBufferMessage
	{
		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x00089393 File Offset: 0x00087593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterSceneByServerScNotify> Parser
		{
			get
			{
				return EnterSceneByServerScNotify._parser;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x0008939A File Offset: 0x0008759A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterSceneByServerScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x000893AC File Offset: 0x000875AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterSceneByServerScNotify.Descriptor;
			}
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x000893B3 File Offset: 0x000875B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneByServerScNotify()
		{
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000893BC File Offset: 0x000875BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneByServerScNotify(EnterSceneByServerScNotify other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x00089424 File Offset: 0x00087624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneByServerScNotify Clone()
		{
			return new EnterSceneByServerScNotify(this);
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x0008942C File Offset: 0x0008762C
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x00089434 File Offset: 0x00087634
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

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x0008943D File Offset: 0x0008763D
		// (set) Token: 0x060031E3 RID: 12771 RVA: 0x00089445 File Offset: 0x00087645
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

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x0008944E File Offset: 0x0008764E
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x00089456 File Offset: 0x00087656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x0008945F File Offset: 0x0008765F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterSceneByServerScNotify);
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x00089470 File Offset: 0x00087670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterSceneByServerScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && object.Equals(this.Lineup, other.Lineup) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000894D4 File Offset: 0x000876D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.Reason != EnterSceneReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x00089545 File Offset: 0x00087745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0008954D File Offset: 0x0008774D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x00089558 File Offset: 0x00087758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lineup_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Lineup);
			}
			if (this.Reason != EnterSceneReason.None)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Reason);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x000895D0 File Offset: 0x000877D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.Reason != EnterSceneReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x00089640 File Offset: 0x00087840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterSceneByServerScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.Reason != EnterSceneReason.None)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x000896D4 File Offset: 0x000878D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x000896E0 File Offset: 0x000878E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 96U)
					{
						if (num != 106U)
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
						this.Reason = (EnterSceneReason)input.ReadEnum();
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

		// Token: 0x040013D9 RID: 5081
		private static readonly MessageParser<EnterSceneByServerScNotify> _parser = new MessageParser<EnterSceneByServerScNotify>(() => new EnterSceneByServerScNotify());

		// Token: 0x040013DA RID: 5082
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013DB RID: 5083
		public const int SceneFieldNumber = 13;

		// Token: 0x040013DC RID: 5084
		private SceneInfo scene_;

		// Token: 0x040013DD RID: 5085
		public const int LineupFieldNumber = 9;

		// Token: 0x040013DE RID: 5086
		private LineupInfo lineup_;

		// Token: 0x040013DF RID: 5087
		public const int ReasonFieldNumber = 12;

		// Token: 0x040013E0 RID: 5088
		private EnterSceneReason reason_;
	}
}
