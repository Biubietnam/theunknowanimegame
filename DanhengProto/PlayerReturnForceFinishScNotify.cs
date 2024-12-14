using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CCF RID: 3279
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnForceFinishScNotify : IMessage<PlayerReturnForceFinishScNotify>, IMessage, IEquatable<PlayerReturnForceFinishScNotify>, IDeepCloneable<PlayerReturnForceFinishScNotify>, IBufferMessage
	{
		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x06009247 RID: 37447 RVA: 0x0018417D File Offset: 0x0018237D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnForceFinishScNotify> Parser
		{
			get
			{
				return PlayerReturnForceFinishScNotify._parser;
			}
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x06009248 RID: 37448 RVA: 0x00184184 File Offset: 0x00182384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnForceFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x06009249 RID: 37449 RVA: 0x00184196 File Offset: 0x00182396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnForceFinishScNotify.Descriptor;
			}
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x0018419D File Offset: 0x0018239D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnForceFinishScNotify()
		{
		}

		// Token: 0x0600924B RID: 37451 RVA: 0x001841A5 File Offset: 0x001823A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnForceFinishScNotify(PlayerReturnForceFinishScNotify other) : this()
		{
			this.pHEJGLEMKKM_ = ((other.pHEJGLEMKKM_ != null) ? other.pHEJGLEMKKM_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600924C RID: 37452 RVA: 0x001841DA File Offset: 0x001823DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnForceFinishScNotify Clone()
		{
			return new PlayerReturnForceFinishScNotify(this);
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600924D RID: 37453 RVA: 0x001841E2 File Offset: 0x001823E2
		// (set) Token: 0x0600924E RID: 37454 RVA: 0x001841EA File Offset: 0x001823EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OINMIFEJJPF PHEJGLEMKKM
		{
			get
			{
				return this.pHEJGLEMKKM_;
			}
			set
			{
				this.pHEJGLEMKKM_ = value;
			}
		}

		// Token: 0x0600924F RID: 37455 RVA: 0x001841F3 File Offset: 0x001823F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnForceFinishScNotify);
		}

		// Token: 0x06009250 RID: 37456 RVA: 0x00184201 File Offset: 0x00182401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnForceFinishScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PHEJGLEMKKM, other.PHEJGLEMKKM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009251 RID: 37457 RVA: 0x00184234 File Offset: 0x00182434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pHEJGLEMKKM_ != null)
			{
				num ^= this.PHEJGLEMKKM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009252 RID: 37458 RVA: 0x00184270 File Offset: 0x00182470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009253 RID: 37459 RVA: 0x00184278 File Offset: 0x00182478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009254 RID: 37460 RVA: 0x00184281 File Offset: 0x00182481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pHEJGLEMKKM_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PHEJGLEMKKM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x001842B4 File Offset: 0x001824B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pHEJGLEMKKM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PHEJGLEMKKM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x001842F4 File Offset: 0x001824F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnForceFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pHEJGLEMKKM_ != null)
			{
				if (this.pHEJGLEMKKM_ == null)
				{
					this.PHEJGLEMKKM = new OINMIFEJJPF();
				}
				this.PHEJGLEMKKM.MergeFrom(other.PHEJGLEMKKM);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009257 RID: 37463 RVA: 0x00184348 File Offset: 0x00182548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x00184354 File Offset: 0x00182554
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
					if (this.pHEJGLEMKKM_ == null)
					{
						this.PHEJGLEMKKM = new OINMIFEJJPF();
					}
					input.ReadMessage(this.PHEJGLEMKKM);
				}
			}
		}

		// Token: 0x04003877 RID: 14455
		private static readonly MessageParser<PlayerReturnForceFinishScNotify> _parser = new MessageParser<PlayerReturnForceFinishScNotify>(() => new PlayerReturnForceFinishScNotify());

		// Token: 0x04003878 RID: 14456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003879 RID: 14457
		public const int PHEJGLEMKKMFieldNumber = 4;

		// Token: 0x0400387A RID: 14458
		private OINMIFEJJPF pHEJGLEMKKM_;
	}
}
