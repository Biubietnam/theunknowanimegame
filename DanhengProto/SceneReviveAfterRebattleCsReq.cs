using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001089 RID: 4233
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneReviveAfterRebattleCsReq : IMessage<SceneReviveAfterRebattleCsReq>, IMessage, IEquatable<SceneReviveAfterRebattleCsReq>, IDeepCloneable<SceneReviveAfterRebattleCsReq>, IBufferMessage
	{
		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0600BCC1 RID: 48321 RVA: 0x001FCE85 File Offset: 0x001FB085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneReviveAfterRebattleCsReq> Parser
		{
			get
			{
				return SceneReviveAfterRebattleCsReq._parser;
			}
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0600BCC2 RID: 48322 RVA: 0x001FCE8C File Offset: 0x001FB08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneReviveAfterRebattleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0600BCC3 RID: 48323 RVA: 0x001FCE9E File Offset: 0x001FB09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneReviveAfterRebattleCsReq.Descriptor;
			}
		}

		// Token: 0x0600BCC4 RID: 48324 RVA: 0x001FCEA5 File Offset: 0x001FB0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneReviveAfterRebattleCsReq()
		{
		}

		// Token: 0x0600BCC5 RID: 48325 RVA: 0x001FCEAD File Offset: 0x001FB0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneReviveAfterRebattleCsReq(SceneReviveAfterRebattleCsReq other) : this()
		{
			this.rebattleType_ = other.rebattleType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCC6 RID: 48326 RVA: 0x001FCED2 File Offset: 0x001FB0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneReviveAfterRebattleCsReq Clone()
		{
			return new SceneReviveAfterRebattleCsReq(this);
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600BCC7 RID: 48327 RVA: 0x001FCEDA File Offset: 0x001FB0DA
		// (set) Token: 0x0600BCC8 RID: 48328 RVA: 0x001FCEE2 File Offset: 0x001FB0E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RebattleType RebattleType
		{
			get
			{
				return this.rebattleType_;
			}
			set
			{
				this.rebattleType_ = value;
			}
		}

		// Token: 0x0600BCC9 RID: 48329 RVA: 0x001FCEEB File Offset: 0x001FB0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneReviveAfterRebattleCsReq);
		}

		// Token: 0x0600BCCA RID: 48330 RVA: 0x001FCEF9 File Offset: 0x001FB0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneReviveAfterRebattleCsReq other)
		{
			return other != null && (other == this || (this.RebattleType == other.RebattleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCCB RID: 48331 RVA: 0x001FCF28 File Offset: 0x001FB128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RebattleType != RebattleType.None)
			{
				num ^= this.RebattleType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BCCC RID: 48332 RVA: 0x001FCF6D File Offset: 0x001FB16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BCCD RID: 48333 RVA: 0x001FCF75 File Offset: 0x001FB175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCCE RID: 48334 RVA: 0x001FCF7E File Offset: 0x001FB17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RebattleType != RebattleType.None)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.RebattleType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BCCF RID: 48335 RVA: 0x001FCFB0 File Offset: 0x001FB1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RebattleType != RebattleType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RebattleType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BCD0 RID: 48336 RVA: 0x001FCFEE File Offset: 0x001FB1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneReviveAfterRebattleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RebattleType != RebattleType.None)
			{
				this.RebattleType = other.RebattleType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BCD1 RID: 48337 RVA: 0x001FD01F File Offset: 0x001FB21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCD2 RID: 48338 RVA: 0x001FD028 File Offset: 0x001FB228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RebattleType = (RebattleType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004CC8 RID: 19656
		private static readonly MessageParser<SceneReviveAfterRebattleCsReq> _parser = new MessageParser<SceneReviveAfterRebattleCsReq>(() => new SceneReviveAfterRebattleCsReq());

		// Token: 0x04004CC9 RID: 19657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CCA RID: 19658
		public const int RebattleTypeFieldNumber = 11;

		// Token: 0x04004CCB RID: 19659
		private RebattleType rebattleType_;
	}
}
