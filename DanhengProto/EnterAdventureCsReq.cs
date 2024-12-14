using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200042F RID: 1071
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterAdventureCsReq : IMessage<EnterAdventureCsReq>, IMessage, IEquatable<EnterAdventureCsReq>, IDeepCloneable<EnterAdventureCsReq>, IBufferMessage
	{
		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000832E4 File Offset: 0x000814E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterAdventureCsReq> Parser
		{
			get
			{
				return EnterAdventureCsReq._parser;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x000832EB File Offset: 0x000814EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterAdventureCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x000832FD File Offset: 0x000814FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAdventureCsReq.Descriptor;
			}
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00083304 File Offset: 0x00081504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAdventureCsReq()
		{
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x0008330C File Offset: 0x0008150C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAdventureCsReq(EnterAdventureCsReq other) : this()
		{
			this.mapId_ = other.mapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x00083331 File Offset: 0x00081531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAdventureCsReq Clone()
		{
			return new EnterAdventureCsReq(this);
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x00083339 File Offset: 0x00081539
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x00083341 File Offset: 0x00081541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x0008334A File Offset: 0x0008154A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAdventureCsReq);
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x00083358 File Offset: 0x00081558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAdventureCsReq other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x00083388 File Offset: 0x00081588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x000833C7 File Offset: 0x000815C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x000833CF File Offset: 0x000815CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000833D8 File Offset: 0x000815D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MapId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x0008340C File Offset: 0x0008160C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x0008344A File Offset: 0x0008164A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAdventureCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x0008347B File Offset: 0x0008167B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00083484 File Offset: 0x00081684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MapId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001307 RID: 4871
		private static readonly MessageParser<EnterAdventureCsReq> _parser = new MessageParser<EnterAdventureCsReq>(() => new EnterAdventureCsReq());

		// Token: 0x04001308 RID: 4872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001309 RID: 4873
		public const int MapIdFieldNumber = 12;

		// Token: 0x0400130A RID: 4874
		private uint mapId_;
	}
}
